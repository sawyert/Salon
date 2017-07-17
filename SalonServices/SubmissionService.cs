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
                catch(Exception ex)
                {
                    lTransaction.Rollback();
                    throw;
                }
            }

            pCreateSubmission.SubmissionCreated = true;
            return pCreateSubmission;
        }

        public Task<SubmissionResultsDto> GetSubmissionResults(int pSubmissionId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSubmissionResults(SubmissionResultsDto pSubmissionResults)
        {
            throw new NotImplementedException();
        }
    }
}
