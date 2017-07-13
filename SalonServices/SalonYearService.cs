using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SalonServices.Dto.Submission;

namespace SalonServices
{
    public class SalonYearService : ISalonYearService
    {
        public Task<CreateSalonDto> CreateSalon(CreateSalonDto pSalonDto)
        {
            throw new NotImplementedException();
        }

        public Task<CreateSalonYearDto> CreateSalonYear(CreateSalonYearDto pSalonYearDto)
        {
            throw new NotImplementedException();
        }

        public Task<List<FullSalonInformationDto>> GetFullSalonInformation()
        {
            throw new NotImplementedException();
        }

        public Task<List<SalonYearInformationDto>> GetSalonYears()
        {
            throw new NotImplementedException();
        }
    }
}
