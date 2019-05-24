using GenFu;
using NUnit.Framework;
using SalonServices.Dto;
using SalonServices.Dto.Submission;
using SalonServices.Entities;
using SalonServices.Mappings;
using SalonServices.Tests.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Tests
{
    [TestFixture]
    public class ReferenceMapperTests
    {
        [SetUp]
        public void Setup()
        {
            Mapping.CreateConfiguration();
        }

        [Test]
        public void MapCountries()
        {
            MappingTestHelpers.MapFromModelAndBack<CountryDto, CountryEntity>();
        }

        [Test]
        public void MapCreateCountries()
        {
            MappingTestHelpers.MapFromModelAndBack<CreateCountryDto, CountryEntity>();
        }

        [Test]
        public void MapOrgs()
        {
            MappingTestHelpers.MapFromModelAndBack<OrganisationDto, PhotoOrganisationEntity > ();
        }

        [Test]
        public void MapSectionTypes()
        {
            MappingTestHelpers.MapFromModelAndBack<SectionTypeDto, SectionTypeEntity>();
        }

        [Test]
        public void MapCreateSectionTypes()
        {
            A.Configure<CreateSectionTypeDto>()
             .Fill(p => p.Id, () => 40);

            MappingTestHelpers.MapFromModelAndBack<CreateSectionTypeDto, SectionTypeEntity>();
        }

        [Test]
        public void MapCircuits()
        {
            MappingTestHelpers.MapFromModelAndBack<CircuitDto, CircuitEntity>();
        }

        [Test]
        public void MapCreateCircuits()
        {
            A.Configure<CreateCircuitDto>()
                   .Fill(p => p.Id, () => 40);

            MappingTestHelpers.MapFromModelAndBack<CreateCircuitDto, CircuitEntity>();
        }
    }
}
