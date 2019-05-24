using System;
using System.Collections.Generic;
using System.Text;
using SalonServices.Dto;
using System.Threading.Tasks;
using SalonServices.Dto.Submission;

namespace SalonServices
{
    public interface IReferenceServices
    {
        Task<List<CountryDto>> GetCountries();
        Task<List<CountryDto>> GetSuccessfulCountries(int pPersonId);
        Task<CountryDto> CreateCountry(CreateCountryDto pCountry);
        Task UpdateCountry(CountryDto pCountryDto);
        Task<bool> DeleteCountry(int id);
        Task<CountryDto> GetCountryById(int id);

        Task<List<OrganisationDto>> GetOrganisations();

        Task<List<CircuitDto>> GetCircuits();

        Task<List<SectionTypeDto>> GetSectionTypes();
        Task<SectionTypeDto> CreateSectionType(CreateSectionTypeDto pSectionType);
        Task UpdateSectionType(SectionTypeDto pSectionType);
        Task<bool> DeleteSectionType(int id);
        Task<SectionTypeDto> GetSectionTypeById(int id);

        Task<CreateCircuitDto> CreateCircuit(CreateCircuitDto pCreateCircuit);
    }
}
