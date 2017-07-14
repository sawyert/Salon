using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Repositories
{
    public interface ISectionRepository : IGenericRepository<SectionEntity>
    {
        Task<List<SectionEntity>> GetSectionsBySalonYearSectionTypeIds(int salonYearId, List<int> sectionTypeIds);
    }
}
