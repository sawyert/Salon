using System;
using NUnit.Framework;
using NSubstitute;
using SalonServices.Repositories;
using SalonServices.Dto;
using System.Collections.Generic;
using SalonServices.Entities;
using SalonServices.Mappings;
using System.Threading.Tasks;

namespace SalonServices.Tests
{
    [TestFixture]
    public class CountryTests
    {
        private ICountryRepository referenceRespository;
        private IReferenceServices referenceServices;

        [SetUp]
        public void Setup()
        {
            this.referenceRespository = Substitute.For<ICountryRepository>();
            this.referenceServices = new ReferenceServices(this.referenceRespository);

            Mapping.CreateConfiguration();
        }

        [Test]
        public async Task ListCountries()
        {
            this.referenceRespository.ListCountries().Returns(new List<CountryEntity>() { new CountryEntity(), new CountryEntity() });
            List<CountryDto> lCountries = await this.referenceServices.ListCountries();
            Assert.AreEqual(2, lCountries.Count);
        }
    }
}
