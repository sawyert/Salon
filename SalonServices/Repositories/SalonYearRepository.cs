using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalonServices.Repositories
{
    public class SalonYearRepository : ISalonYearRepository
    {
        private readonly ISalonDbContext dbContext;

        public SalonYearRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public async Task<SalonYearEntity> Add(SalonYearEntity pEntity)
        {
            await this.dbContext.SalonYears.AddAsync(pEntity);
            await this.dbContext.SaveChangesAsync();
            return pEntity;
        }

        public async Task<SalonYearEntity> GetById(int id)
        {
            return await this.dbContext.SalonYears.FirstOrDefaultAsync(coun => coun.Id == id);
        }

        public async Task Update(SalonYearEntity pEntity)
        {
            this.dbContext.SalonYears.Update(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task Delete(SalonYearEntity pEntity)
        {
            this.dbContext.SalonYears.Remove(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<List<SalonYearEntity>> GetSalonYearsWithAccreditations(int pYear)
        {
            return await this.dbContext.SalonYears.Where(sy => sy.Year == pYear).Include(sy => sy.Accreditations).ToListAsync();
        }

        public async Task<List<int>> GetSalonYearsIdsByCircuitId(int pCircuitId)
        {
            return await this.dbContext.SalonYears.Where(sy => sy.CircuitId == pCircuitId).Select(sy => sy.Id).ToListAsync();
        }
    }
}
