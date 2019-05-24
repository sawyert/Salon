using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SalonServices.Dto.Submission;
using SalonServices.Repositories;
using System.Linq;
using SalonServices.Mappings;
using SalonServices.Entities;

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
            var lEntityToAdd = Mapping.Mapper.Map<SalonEntity>(pSalonDto);
            var lEntityCreated = await this._salonRepository.Add(lEntityToAdd);
            return Mapping.Mapper.Map<CreateSalonDto>(lEntityCreated);
        }

        public async Task<CreateSalonYearDto> CreateSalonYear(CreateSalonYearDto pSalonYearDto)
        {
            var lEntityToAdd = Mapping.Mapper.Map<SalonYearEntity>(pSalonYearDto);
            var lEntityCreated = await this._salonYearRepository.Add(lEntityToAdd);
            return Mapping.Mapper.Map<CreateSalonYearDto>(lEntityCreated);
        }

        public async Task<List<FullSalonInformationDto>> GetFullSalonInformation()
        {
            return await this._salonRepository.GetFullSalonInformation();
        }

        public async Task<List<SalonYearInformationDto>> GetSalonYears(int pYear)
        {
            var lSalonYearEntities = await this._salonYearRepository.GetSalonYearsWithAccreditations(pYear);

            return lSalonYearEntities.Select(sye => Mapping.Mapper.Map<SalonYearInformationDto>(sye)).ToList();
        }
    }
}
