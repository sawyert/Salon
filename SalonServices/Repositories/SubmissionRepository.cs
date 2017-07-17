using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System.Threading.Tasks;
using SalonServices.Dto.Submission;
using System;
using System.Linq;

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
                                SubmissionId = sub.Id,
                                Entries = sub.Entries.Select(ent => new SubmissionResultsEntryDto
                                {
                                    Id = ent.Id,
                                    Score = ent.Score,
                                    IsAwarded = ent.IsAwarded,
                                    IsAccepted = ent.IsAccepted,
                                    ImageName = ent.Image.Name
                                })
                            }).FirstOrDefaultAsync();
        }

        public async Task<SubmissionEntity> GetSubmissionWithEntries(int pSubmissionId)
        {
            return await this.dbContext.Submissions.Include(sub => sub.Entries).FirstOrDefaultAsync(sub => sub.Id == pSubmissionId);
        }
    }
}
