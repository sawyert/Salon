using System;
using System.Collections.Generic;
using System.Text;
using SalonServices.Repositories;
using SalonServices.Dto;
using SalonServices.Entities;
using System.Linq;
using SalonServices.Mappings;
using System.Threading.Tasks;
using SalonServices.Dto.Submission;

namespace SalonServices
{
    public class ReferenceServices : IReferenceServices
    {
        private readonly ICountryRepository referenceRepository;

        public ReferenceServices(ICountryRepository referenceRepository)
        {
            this.referenceRepository = referenceRepository;
        }

        public Task<CreateCircuitDto> CreateCircuit(CreateCircuitDto pCreateCircuit)
        {
            throw new NotImplementedException();
        }

        public async Task<CountryDto> CreateCountry(CreateCountryDto pCountry)
        {
            var lCountryEntity = Mapping.Mapper.Map<CountryEntity>(pCountry);

            lCountryEntity = await this.referenceRepository.Add(lCountryEntity);
            CountryDto lReturn = Mapping.Mapper.Map<CountryDto>(pCountry);
            lReturn.Id = lCountryEntity.Id;
            return lReturn;
        }

        public async Task<bool> DeleteCountry(int id)
        {
            var lCountryEntity = await this.referenceRepository.GetById(id);
            await this.referenceRepository.Delete(lCountryEntity);
            return true;
        }

        public Task<List<CircuitDto>> GetCircuits()
        {
            throw new NotImplementedException();
        }

        public async Task<CountryDto> GetCountryById(int id)
        {
            CountryEntity lCountryEntity = await this.referenceRepository.GetById(id);
            CountryDto lReturn = Mapping.Mapper.Map<CountryDto>(lCountryEntity);

            return lReturn;
        }

        public Task<List<OrganisationDto>> GetOrganisations()
        {
            throw new NotImplementedException();
        }

        public async Task<List<CountryDto>> ListCountries()
        {
            List<CountryEntity> lCountries = await this.referenceRepository.ListCountries();

            List<CountryDto> lReturn = lCountries.Select(coun => Mapping.Mapper.Map<CountryDto>(coun)).ToList();

            return lReturn;
        }

        public async Task UpdateCountry(CountryDto pCountryDto)
        {
            CountryEntity lCountryEntity = await this.referenceRepository.GetById(pCountryDto.Id);
             Mapping.Mapper.Map<CountryDto, CountryEntity>(pCountryDto, lCountryEntity);
            await this.referenceRepository.Update(lCountryEntity);
        }
    }
}
