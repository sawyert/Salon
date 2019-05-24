using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System.Threading.Tasks;

namespace SalonServices.Repositories
{
    public class AccreditationRepository : IAccreditationRepository
    {
        private readonly ISalonDbContext dbContext;

        public AccreditationRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public async Task<AccreditationEntity> Add(AccreditationEntity pEntity)
        {
            await this.dbContext.Accreditations.AddAsync(pEntity);
            await this.dbContext.SaveChangesAsync();
            return pEntity;
        }

        public async Task<AccreditationEntity> GetById(int id)
        {
            return await this.dbContext.Accreditations.FirstOrDefaultAsync(coun => coun.Id == id);
        }
        
        public async Task Update(AccreditationEntity pEntity)
        {
            this.dbContext.Accreditations.Update(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task Delete(AccreditationEntity pEntity)
        {
            this.dbContext.Accreditations.Remove(pEntity);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
