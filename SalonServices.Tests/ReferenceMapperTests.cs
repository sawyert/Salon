using NUnit.Framework;
using SalonServices.Dto;
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

    }
}
