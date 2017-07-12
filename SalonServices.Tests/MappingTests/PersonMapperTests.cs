using NUnit.Framework;
using SalonServices.Dto;
using SalonServices.Entities;
using SalonServices.Mappings;
using SalonServices.Tests.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Tests.Unit.MappingTests
{
    [TestFixture]
    public class PersonMapperTests
    {
        [SetUp]
        public void Setup()
        {
            Mapping.CreateConfiguration();
        }

        [Test]
        public void MapPersonToBasicPersonDto()
        {
            MappingTestHelpers.MapFromModelAndBack<BasicPersonDto, PersonEntity>();
        }
    }
}
