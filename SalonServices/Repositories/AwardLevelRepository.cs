using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System.Threading.Tasks;

namespace SalonServices.Repositories
{
    public class AwardLevelRepository : IAwardLevelRepository
    {
        private readonly ISalonDbContext dbContext;

        public AwardLevelRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public async Task<AwardLevelEntity> Add(AwardLevelEntity pEntity)
        {
            await this.dbContext.AwardLevels.AddAsync(pEntity);
            await this.dbContext.SaveChangesAsync();
            return pEntity;
        }

        public async Task<AwardLevelEntity> GetById(int id)
        {
            return await this.dbContext.AwardLevels.FirstOrDefaultAsync(coun => coun.Id == id);
        }

        public async Task Update(AwardLevelEntity pEntity)
        {
            this.dbContext.AwardLevels.Update(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task Delete(AwardLevelEntity pEntity)
        {
            this.dbContext.AwardLevels.Remove(pEntity);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
