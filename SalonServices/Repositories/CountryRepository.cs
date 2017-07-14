using System;
using System.Collections.Generic;
using System.Text;
using SalonServices.Dto;
using SalonServices.Entities;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalonServices.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ISalonDbContext dbContext;

        public CountryRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public async Task<CountryEntity> Add(CountryEntity pEntity)
        {
            await this.dbContext.Countries.AddAsync(pEntity);
            await this.dbContext.SaveChangesAsync();
            return pEntity;
        }

        public async Task<CountryEntity> GetById(int id)
        {
            return await this.dbContext.Countries.FirstOrDefaultAsync(coun => coun.Id == id);
        }

        public async Task<List<CountryEntity>> GetCountries()
        {
            return await this.dbContext.Countries.ToListAsync();
        }

        public async Task Update(CountryEntity pEntity)
        {
            this.dbContext.Countries.Update(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task Delete(CountryEntity pEntity)
        {
            this.dbContext.Countries.Remove(pEntity);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
