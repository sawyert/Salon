using System;
using System.Collections.Generic;
using System.Text;
using SalonServices.Dto;
using SalonServices.Entities;
using System.Threading.Tasks;

namespace SalonServices.Repositories
{
    public interface IReferenceRepository
    {
        Task<List<CountryEntity>> ListCountries();
    }
}
