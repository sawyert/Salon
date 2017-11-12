using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Repositories
{
    public interface IPersonRepository : IGenericRepository<PersonEntity>
    {
        Task<PersonEntity> GetWithSubmissionsSalonsAccreditationSections(int pPersonId);
        Task<List<PersonEntity>> GetAll();
        Task<decimal> GetCostPerAcceptance(int id);
        Task<decimal> GetTotalCost(int id);
        Task<int> UnjudgedImageCount(int id);
        Task<int> UnjudgedSalonCount(int id);
    }
}
