using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace SalonServices.Repositories
{
    public class PhotoOrganisationRepository : IPhotoOrganisationRepository
    {
        private readonly ISalonDbContext dbContext;

        public PhotoOrganisationRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public async Task<PhotoOrganisationEntity> Add(PhotoOrganisationEntity pEntity)
        {
            await this.dbContext.PhotoOrganisations.AddAsync(pEntity);
            await this.dbContext.SaveChangesAsync();
            return pEntity;
        }

        public async Task<PhotoOrganisationEntity> GetById(int id)
        {
            return await this.dbContext.PhotoOrganisations.FirstOrDefaultAsync(coun => coun.Id == id);
        }

        public async Task Update(PhotoOrganisationEntity pEntity)
        {
            this.dbContext.PhotoOrganisations.Update(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task Delete(PhotoOrganisationEntity pEntity)
        { 
            this.dbContext.PhotoOrganisations.Remove(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<List<PhotoOrganisationEntity>> GetAllWithAwards()
        {
            return await this.dbContext.PhotoOrganisations.Include(org => org.AwardLevels).ToListAsync();
        }
    }
}
