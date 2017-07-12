using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System.Threading.Tasks;

namespace SalonServices.Repositories
{
    public class SectionTypeRepository : ISectionTypeRepository
    {
        private readonly ISalonDbContext dbContext;

        public SectionTypeRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public async Task<SectionTypeEntity> Add(SectionTypeEntity pEntity)
        {
            await this.dbContext.SectionTypes.AddAsync(pEntity);
            await this.dbContext.SaveChangesAsync();
            return pEntity;
        }

        public async Task<SectionTypeEntity> GetById(int id)
        {
            return await this.dbContext.SectionTypes.FirstOrDefaultAsync(coun => coun.Id == id);
        }

        public async Task Update(SectionTypeEntity pEntity)
        {
            this.dbContext.SectionTypes.Update(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task Delete(SectionTypeEntity pEntity)
        {
            this.dbContext.SectionTypes.Remove(pEntity);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
