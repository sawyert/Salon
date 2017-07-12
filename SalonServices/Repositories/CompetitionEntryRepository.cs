using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System.Threading.Tasks;

namespace SalonServices.Repositories
{
    public class CompetitionEntryRepository : ICompetitionEntryRepository
    {
        private readonly ISalonDbContext dbContext;

        public CompetitionEntryRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public async Task<CompetitionEntryEntity> Add(CompetitionEntryEntity pEntity)
        {
            await this.dbContext.CompetitionEntries.AddAsync(pEntity);
            await this.dbContext.SaveChangesAsync();
            return pEntity;
        }

        public async Task<CompetitionEntryEntity> GetById(int id)
        {
            return await this.dbContext.CompetitionEntries.FirstOrDefaultAsync(coun => coun.Id == id);
        }

        public async Task Update(CompetitionEntryEntity pEntity)
        {
            this.dbContext.CompetitionEntries.Update(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task Delete(CompetitionEntryEntity pEntity)
        {
            this.dbContext.CompetitionEntries.Remove(pEntity);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
