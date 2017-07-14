using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System.Threading.Tasks;
using SalonServices.Dto.Submission;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalonServices.Repositories
{
    public class SalonRepository : ISalonRepository
    {
        private readonly ISalonDbContext dbContext;

        public SalonRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public async Task<SalonEntity> Add(SalonEntity pEntity)
        {
            await this.dbContext.Salons.AddAsync(pEntity);
            await this.dbContext.SaveChangesAsync();
            return pEntity;
        }

        public async Task<SalonEntity> GetById(int id)
        {
            return await this.dbContext.Salons.FirstOrDefaultAsync(coun => coun.Id == id);
        }

        public async Task Update(SalonEntity pEntity)
        {
            this.dbContext.Salons.Update(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task Delete(SalonEntity pEntity)
        {
            this.dbContext.Salons.Remove(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<List<FullSalonInformationDto>> GetFullSalonInformation()
        {
            return await this.dbContext.Salons.Select(sal => new FullSalonInformationDto
            {
                CountryId = sal.CountryId,
                CountryName = sal.Country.Name,
                SalonId = sal.Id,
                SalonName = sal.Name,
                Website = sal.Website
            }).ToListAsync();
        }
    }
}
