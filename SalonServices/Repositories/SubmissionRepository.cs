using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System.Threading.Tasks;
using SalonServices.Dto.Submission;
using System;
using System.Linq;
using System.Collections.Generic;

namespace SalonServices.Repositories
{
    public class SubmissionRepository : ISubmissionRepository
    {
        private readonly ISalonDbContext dbContext;

        public SubmissionRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public async Task<SubmissionEntity> Add(SubmissionEntity pEntity)
        {
            await this.dbContext.Submissions.AddAsync(pEntity);
            await this.dbContext.SaveChangesAsync();
            return pEntity;
        }

        public async Task<SubmissionEntity> GetById(int id)
        {
            return await this.dbContext.Submissions.FirstOrDefaultAsync(sub => sub.Id == id);
        }

        public async Task Update(SubmissionEntity pEntity)
        {
            this.dbContext.Submissions.Update(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task Delete(SubmissionEntity pEntity)
        {
            this.dbContext.Submissions.Remove(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<SubmissionResultsDto> GetSubmissionResults(int pSubmissionId)
        {
            return await this.dbContext.Submissions.Where(sub => sub.Id == pSubmissionId).Select(sub =>
                            new SubmissionResultsDto
                            {
                                DisplayName = sub.SalonYear.Salon.Name + " - " + sub.SalonYear.Name + " (" + sub.SalonYear.Year + ")",
                                PersonId = sub.PersonId,
                                SubmissionId = sub.Id,
                                Entries = sub.Entries.Select(ent => new SubmissionResultsEntryDto
                                {
                                    Id = ent.Id,
                                    Score = ent.Score,
                                    IsAwarded = ent.IsAwarded,
                                    IsAccepted = ent.IsAccepted,
                                    ImageName = ent.Image.Name,
                                    ImageId = ent.Image.Id,
                                    SectionName = ent.Section.SectionType.Name,
                                    AwardDetails = ent.AwardDetails
                                }).OrderBy(x => x.SectionName).ThenBy(x => x.ImageName)
                            }).FirstOrDefaultAsync();
        }

        public async Task<List<SubmissionListItemDto>> GetBasicSubmissionInfoByPersonId(int pPersonId)
        {
            return await this.dbContext.Submissions.Where(sub => sub.PersonId == pPersonId).Select(sub =>
                            new SubmissionListItemDto
                            {
                                DisplayName = sub.SalonYear.Name + " (" + sub.SalonYear.Year + ")",
                                NumberOfEntries = sub.Entries.Count,
                                SubmissionId = sub.Id,
                                EntryDate = sub.EntryDate,
                                HasAccepted = sub.Entries.Any(itm => itm.IsAccepted.HasValue && itm.IsAccepted.Value),
                                AcceptedCount = sub.Entries.Where(itm => itm.IsAccepted.HasValue && itm.IsAccepted.Value).Count(),
                                CountryName = sub.SalonYear.Salon.Country.Name,
                                IsJudged = sub.IsJudged,
                                JudgeDate = sub.SalonYear.JudgeDate.ToString("dd/MM/yyyy"),
                                NotificationDate = sub.SalonYear.NotificationDate.ToString("dd/MM/yyyy"),
                                AccreditationNumbers = string.Join(", ", sub.SalonYear.Accreditations.Select(o => o.SalonNumber))
                            }).OrderByDescending(itm => itm.EntryDate).ToListAsync();
        }
        
        public async Task<SubmissionEntity> GetSubmissionWithEntries(int pSubmissionId)
        {
            return await this.dbContext.Submissions.Include(sub => sub.Entries).FirstOrDefaultAsync(sub => sub.Id == pSubmissionId);
        }

        public List<CompetitionEntryEntity> GetSalonEntriesForImage(int pImageId)
        {
            return this.dbContext.CompetitionEntries.Where(ent => ent.ImageId == pImageId)
                .Include(ent => ent.Section).ThenInclude(sect => sect.SalonYear).ThenInclude(sy => sy.Salon)
                       .Include(ent => ent.Section).ThenInclude(sec => sec.SectionType).OrderByDescending(ent => ent.Section.SalonYear.JudgeDate).ToList();
        }
    }
}