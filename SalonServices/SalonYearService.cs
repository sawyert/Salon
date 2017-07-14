using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SalonServices.Dto.Submission;
using SalonServices.Repositories;
using System.Linq;
using SalonServices.Mappings;

namespace SalonServices
{
    public class SalonYearService : ISalonYearService
    {
        private readonly ISalonRepository _salonRepository;
        private readonly ISalonYearRepository _salonYearRepository;
        private readonly ICountryRepository _countryRepository;

        public SalonYearService(ISalonRepository pSalonRepository, ISalonYearRepository pSalonYearRepository, ICountryRepository pCountryRepository)
        {
            this._countryRepository = pCountryRepository;
            this._salonRepository = pSalonRepository;
            this._salonYearRepository = pSalonYearRepository;
        }

        public async Task<CreateSalonDto> CreateSalon(CreateSalonDto pSalonDto)
        {
            throw new NotImplementedException();
        }

        public async Task<CreateSalonYearDto> CreateSalonYear(CreateSalonYearDto pSalonYearDto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FullSalonInformationDto>> GetFullSalonInformation()
        {
            return await this._salonRepository.GetFullSalonInformation();
        }

        public async Task<List<SalonYearInformationDto>> GetSalonYears()
        {
            var lSalonYearEntities = await this._salonYearRepository.GetSalonYearsWithAccreditations();

            return lSalonYearEntities.Select(sye => Mapping.Mapper.Map<SalonYearInformationDto>(sye)).ToList();
        }
    }
}
