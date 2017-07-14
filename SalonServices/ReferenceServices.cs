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
        private readonly ICountryRepository _countryRepository;
        private readonly ISectionTypeRepository _sectionTypeRepository;
        private readonly IPhotoOrganisationRepository _photoOrganisationRepository;
        private readonly ICircuitRepository _circuitRepository;


        public ReferenceServices(ICountryRepository pCountryRepository, ISectionTypeRepository pSectionTypeRepository, IPhotoOrganisationRepository pPhotoOrganisationRepository, ICircuitRepository pCircuitRepository)
        {
            this._countryRepository = pCountryRepository;
            this._sectionTypeRepository = pSectionTypeRepository;
            this._photoOrganisationRepository = pPhotoOrganisationRepository;
            this._circuitRepository = pCircuitRepository;
        }

        public async Task<CreateCircuitDto> CreateCircuit(CreateCircuitDto pCreateCircuit)
        {
            var lCircuitEntity = Mapping.Mapper.Map<CircuitEntity>(pCreateCircuit);
            var lReturnedCircuitEntity = await this._circuitRepository.Add(lCircuitEntity);
            var lReturn = Mapping.Mapper.Map<CreateCircuitDto>(lReturnedCircuitEntity);
            return lReturn;
        }

        public async Task<CountryDto> CreateCountry(CreateCountryDto pCountry)
        {
            var lCountryEntity = Mapping.Mapper.Map<CountryEntity>(pCountry);

            lCountryEntity = await this._countryRepository.Add(lCountryEntity);
            CountryDto lReturn = Mapping.Mapper.Map<CountryDto>(pCountry);
            lReturn.Id = lCountryEntity.Id;
            return lReturn;
        }

        public async Task<bool> DeleteCountry(int id)
        {
            var lCountryEntity = await this._countryRepository.GetById(id);
            await this._countryRepository.Delete(lCountryEntity);
            return true;
        }

        public async Task<List<CircuitDto>> GetCircuits()
        {
            List<CircuitEntity> lCircuitEnts = await this._circuitRepository.GetAll();
            var lReturn = lCircuitEnts.Select(st => Mapping.Mapper.Map<CircuitDto>(st)).ToList();
            return lReturn;
        }

        public async Task<CountryDto> GetCountryById(int id)
        {
            CountryEntity lCountryEntity = await this._countryRepository.GetById(id);
            CountryDto lReturn = Mapping.Mapper.Map<CountryDto>(lCountryEntity);

            return lReturn;
        }

        public async Task<List<OrganisationDto>> GetOrganisations()
        {
            List<PhotoOrganisationEntity> lOrgEnts = await this._photoOrganisationRepository.GetAllBasic();
            var lReturn = lOrgEnts.Select(st => Mapping.Mapper.Map<OrganisationDto>(st)).ToList();
            return lReturn;
        }

        public async Task<List<SectionTypeDto>> GetSectionTypes()
        {
            List<SectionTypeEntity> lSectionTypes = await this._sectionTypeRepository.GetAll();
            var lReturn = lSectionTypes.Select(st => Mapping.Mapper.Map<SectionTypeDto>(st)).ToList();
            return lReturn;
        }

        public async Task<List<CountryDto>> GetCountries()
        {
            List<CountryEntity> lCountries = await this._countryRepository.GetCountries();
            List<CountryDto> lReturn = lCountries.Select(coun => Mapping.Mapper.Map<CountryDto>(coun)).ToList();
            return lReturn;
        }

        public async Task UpdateCountry(CountryDto pCountryDto)
        {
            CountryEntity lCountryEntity = await this._countryRepository.GetById(pCountryDto.Id);
             Mapping.Mapper.Map<CountryDto, CountryEntity>(pCountryDto, lCountryEntity);
            await this._countryRepository.Update(lCountryEntity);
        }
    }
}
