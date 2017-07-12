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
    }
}
