using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Tests.Integration.RepositoryTests
{
    internal static class EntitiesHelper
    {
        internal static SalonYearEntity GetSalonYear()
        {
            return new SalonYearEntity
            {
                Name = "year",
                Salon = GetSalon()
            };
        }

        internal static SalonEntity GetSalon()
        {
            return new SalonEntity
            {
                Name = "this name",
                Website = "web",
                Country = GetCountry()
            };
        }

        internal static CountryEntity GetCountry()
        {
            return new CountryEntity
            {
                Name = "country 1"
            };
        }

        internal static SectionEntity GetSection()
        {
            return new SectionEntity
            {
                SalonYear = GetSalonYear(),
                SectionType = GetSectionType()
            };
        }

        internal static SectionTypeEntity GetSectionType()
        {
            return new SectionTypeEntity { Name = "section type" };
        }

        internal static ImageEntity GetImage()
        {
            return new ImageEntity { Name = "org1", Person = GetPerson() };
        }

        internal static PersonEntity GetPerson()
        {
            return  new PersonEntity { Name = "george" };
        }
    }
}
