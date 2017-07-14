using GenFu;
using NUnit.Framework;
using SalonServices.Dto.Submission;
using SalonServices.Entities;
using SalonServices.Mappings;
using SalonServices.Tests.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Tests.Unit.MappingTests
{
    [TestFixture]
    public class SalonYearMapperTests
    {
        [SetUp]
        public void Setup()
        {
            Mapping.CreateConfiguration();
        }

        [Test]
        public void MapSalonYearInformationToEntityAndBack()
        {
            A.Configure<SalonYearInformationDto>()
                    .Fill(p => p.Accreditations, () => A.ListOf<SalonYearAccreditationDto>());

            MappingTestHelpers.MapFromModelAndBack<SalonYearInformationDto, SalonYearEntity>();
        }

        [Test]
        public void MapCreateSalonYearToEntityAndBack()
        {
            A.Configure<CreateSalonYearDto>()
                .Fill(p => p.Id, () => 40);

            MappingTestHelpers.MapFromModelAndBack<CreateSalonYearDto, SalonYearEntity>();
        }

        [Test]
        public void MapSalonToEntityAndBack()
        {
            A.Configure<CreateSalonDto>()
                .Fill(p => p.SalonId, () => 40)
                .Fill(p => p.CountryId, () => 50);

            MappingTestHelpers.MapFromModelAndBack<CreateSalonDto, SalonEntity>(null, exp => exp.Excluding(prop => prop.CountryName));
        }
    }
}
