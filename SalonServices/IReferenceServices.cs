using System;
using System.Collections.Generic;
using System.Text;
using SalonServices.Dto;
using System.Threading.Tasks;

namespace SalonServices
{
    public interface IReferenceServices
    {
        Task<List<CountryDto>> ListCountries();
    }
}
