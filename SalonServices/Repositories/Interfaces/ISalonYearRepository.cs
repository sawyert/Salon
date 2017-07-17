using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Repositories
{
    public interface ISalonYearRepository : IGenericRepository<SalonYearEntity>
    {
        Task<List<SalonYearEntity>> GetSalonYearsWithAccreditations(int pYear);
        Task<List<int>> GetSalonYearsIdsByCircuitId(int pCircuitId);

    }
}
