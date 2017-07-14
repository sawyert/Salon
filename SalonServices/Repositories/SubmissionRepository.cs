using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System.Threading.Tasks;

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
    }
}
