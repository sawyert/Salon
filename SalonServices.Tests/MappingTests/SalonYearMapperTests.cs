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
    }
}
