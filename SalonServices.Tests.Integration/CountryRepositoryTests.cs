using NUnit.Framework;
using SalonServices.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Tests.Integration
{
    public class CountryRepositoryTests : AbstractDbTest<SalonDbContext>
    {
        private CountryRepository countryRepository;

        [SetUp]
        public void Setup()
        {
            countryRepository = new CountryRepository(base._DbContext);
        }

        [Test]
        public async Task AddCountry_AddsToDb()
        {
            // Act
            var lResult = await countryRepository.Add(new Entities.CountryEntity { Name = "test" });

            // Assert
            Assert.IsTrue(lResult.Id > 0);
            var lCreatedEntity = await countryRepository.GetById(lResult.Id);
            Assert.IsNotNull(lCreatedEntity);
            Assert.AreEqual("test", lCreatedEntity.Name);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }

    }
}
