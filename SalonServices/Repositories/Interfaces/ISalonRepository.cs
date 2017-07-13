using SalonServices.Dto.Submission;
using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Repositories
{
    public interface ISalonRepository : IGenericRepository<SalonEntity>
    {
        Task<List<FullSalonInformationDto>> GetFullSalonInformation();
    }
}
