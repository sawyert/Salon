using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Repositories
{
    public interface ICircuitRepository : IGenericRepository<CircuitEntity>
    {
        Task<List<CircuitEntity>> GetAll();
    }
}
