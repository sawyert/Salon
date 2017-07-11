using System;
using System.Collections.Generic;
using System.Text;
using SalonServices.Repositories;
using SalonServices.Dto;
using SalonServices.Entities;
using System.Linq;
using SalonServices.Mappings;
using System.Threading.Tasks;

namespace SalonServices
{
    public class ReferenceServices : IReferenceServices
    {
        private readonly ICountryRepository referenceRepository;

        public ReferenceServices(ICountryRepository referenceRepository)
        {
            this.referenceRepository = referenceRepository;
        }

        public async Task<CountryDto> CreateCountry(CreateCountryDto pCountry)
        {
            var lCountryEntity = Mapping.Mapper.Map<CountryEntity>(pCountry);

            lCountryEntity = await this.referenceRepository.Add(lCountryEntity);
            
            return Mapping.Mapper.Map<CountryDto>(lCountryEntity);
        }

        public Task<bool> DeleteCountry(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CountryDto> GetCountryById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CountryDto>> ListCountries()
        {
            List<CountryEntity> lCountries = await this.referenceRepository.ListCountries();

            List<CountryDto> lReturn = lCountries.Select(coun => Mapping.Mapper.Map<CountryDto>(coun)).ToList();

            return lReturn;
        }

        public Task UpdateCountry(CountryDto pCountryDto)
        {
            throw new NotImplementedException();
        }
    }
}
