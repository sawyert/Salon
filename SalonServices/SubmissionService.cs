using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SalonServices.Dto.Submission;
using SalonServices.Repositories;
using System.Linq;
using SalonServices.Mappings;
using SalonServices.Entities;

namespace SalonServices
{
    public class SubmissionService : ISubmissionService
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly ISubmissionRepository _submissionRepository;
        private readonly ISalonYearRepository _salonYearRepository;
        private readonly IImageService _imageService;
        private readonly IDbTransaction _dbTransaction;

        public SubmissionService(ISectionRepository pSectionRepository, ISubmissionRepository pSubmissionRepository, ISalonYearRepository pSalonYearRepository, IImageService pImageService, IDbTransaction pDbTransaction)
        {
            this._sectionRepository = pSectionRepository;
            this._submissionRepository = pSubmissionRepository;
            this._salonYearRepository = pSalonYearRepository;
            this._imageService = pImageService;
            this._dbTransaction = pDbTransaction;
        }

        public async Task<SubmissionSaveDto> CreateSubmission(SubmissionSaveDto pCreateSubmission)
        {
            List<int> lSalonYearIds = new List<int>();

            if (pCreateSubmission.SalonYearId.HasValue)
            {
                lSalonYearIds.Add(pCreateSubmission.SalonYearId.Value);
            }
            else if (pCreateSubmission.CircuitId.HasValue)
            {
                lSalonYearIds.AddRange(await this._salonYearRepository.GetSalonYearsIdsByCircuitId(pCreateSubmission.CircuitId.Value));
            }
            else
            {
                throw new ArgumentException("Salon year id or circuit id must be specified in order to create a submission");
            }

            using (var lTransaction = await this._dbTransaction.BeginTransactionAsync())
            {
                try
                {
                    foreach (var lSalonYearId in lSalonYearIds)
                    {
                        var lAvailableSections = await this._sectionRepository.GetSectionsBySalonYearSectionTypeIds(lSalonYearId, pCreateSubmission.Sections.Select(sec => sec.SectionTypeId).ToList());
                        // Create new entity each time
                        var lSubmissionEntity = Mapping.Mapper.Map<SubmissionEntity>(pCreateSubmission);
                        // Not needed when just a single salon year id, but is for circuit id
                        lSubmissionEntity.SalonYearId = lSalonYearId;

                        foreach (var lSection in pCreateSubmission.Sections)
                        {
                            var lExistingSectionItem = lAvailableSections.Where(t => t.SectionTypeId == lSection.SectionTypeId).FirstOrDefault();

                            if (lExistingSectionItem == null)
                            {
                                lExistingSectionItem = new SectionEntity()
                                {
                                    SalonYearId = lSalonYearId,
                                    Entries = new List<CompetitionEntryEntity>(),
                                    SectionTypeId = lSection.SectionTypeId
                                };
                            }

                            foreach (var lImage in lSection.Images)
                            {
                                var lCompetitionEntry = new CompetitionEntryEntity
                                {
                                    Section = lExistingSectionItem
                                };
                                if (lImage.ImageId.HasValue)
                                {
                                    lCompetitionEntry.ImageId = lImage.ImageId.Value;
                                }
                                else
                                {
                                    var lImageEntity = Mapping.Mapper.Map<ImageEntity>(lImage);
                                    lImageEntity.PersonId = pCreateSubmission.PersonId;
                                    lImageEntity.ThumbnailLocation = this._imageService.SaveImage(new ImageSaveDetails { FileName = $"{Guid.NewGuid()}.{lImage.Extension}", ImageContent = lImage.ImageThumbnail });

                                    lCompetitionEntry.Image = lImageEntity;
                                }
                                lSubmissionEntity.Entries.Add(lCompetitionEntry);
                            }
                        }
                        await this._submissionRepository.Add(lSubmissionEntity);
                    }
                    lTransaction.Commit();
                }
                catch (Exception)
                {
                    lTransaction.Rollback();
                    throw;
                }
            }

            pCreateSubmission.SubmissionCreated = true;
            return pCreateSubmission;
        }

        public async Task<List<SubmissionListItemDto>> GetBasicSubmissionInfoByPersonId(int pPersonId)
        {
            return await this._submissionRepository.GetBasicSubmissionInfoByPersonId(pPersonId);
        }

        public async Task<SubmissionResultsDto> GetSubmissionResults(int pSubmissionId)
        {
            return await this._submissionRepository.GetSubmissionResults(pSubmissionId);
        }

        public async Task UpdateSubmissionResults(SubmissionResultsDto pSubmissionResults)
        {
            var lSubmissionEntity = await this._submissionRepository.GetSubmissionWithEntries(pSubmissionResults.SubmissionId);
            lSubmissionEntity.IsJudged = true;
            for (int i = 0; i < lSubmissionEntity.Entries.Count; i++)
            {
                var lSubmissionEntryDto = pSubmissionResults.Entries.FirstOrDefault(ent => ent.Id == lSubmissionEntity.Entries[i].Id);
                if (lSubmissionEntryDto != null)
                {
                    // Set the item in the list so that it is updated on the save
                    lSubmissionEntity.Entries[i] = Mapping.Mapper.Map(lSubmissionEntryDto, lSubmissionEntity.Entries[i]);
                }
                else
                {
                    throw new ArgumentException($"Competition entry with id of {lSubmissionEntity.Entries[i].Id} was missing in the update for submission with id of {pSubmissionResults.SubmissionId}");
                }
            }
            await this._submissionRepository.Update(lSubmissionEntity);
        }
    }
}
