using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Repositories
{
    public interface ISectionTypeRepository : IGenericRepository<SectionTypeEntity>
    {
        Task<List<SectionTypeEntity>> GetAll();

        Task<List<string>> FetchSectionTypeCodes();
    }
}
