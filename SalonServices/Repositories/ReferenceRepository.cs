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
    public class ReferenceRepository : IReferenceRepository
    {
        private readonly ISalonDbContext dbContext;

        public ReferenceRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public async Task<List<CountryEntity>> ListCountries()
        {
            return await this.dbContext.Countries.ToListAsync();
        }
    }
}
