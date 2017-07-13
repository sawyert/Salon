using SalonServices.Dto.Submission;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices
{
    public interface ISalonYearService
    {
        Task<List<FullSalonInformationDto>> GetFullSalonInformation();

        Task<List<SalonYearInformationDto>> GetSalonYears();

        Task<CreateSalonYearDto> CreateSalonYear(CreateSalonYearDto pSalonYearDto);

        Task<CreateSalonDto> CreateSalon(CreateSalonDto pSalonDto);
    }
}
