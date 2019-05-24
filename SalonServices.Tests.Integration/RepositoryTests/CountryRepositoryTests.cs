using NUnit.Framework;
using SalonServices.Entities;
using SalonServices.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Tests.Integration.RepositoryTests
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

        [Test]
        public async Task GetCountry_GetsFromDb()
        {
            // Arrange
            var lCreatedEntity = await countryRepository.Add(new Entities.CountryEntity { Name = "test" });

            // Act
            var lResult = await countryRepository.GetById(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("test", lResult.Name);
        }

        [Test]
        public async Task UpdateCountry_SetsNameInDb()
        {
            // Arrange
            var lCreatedEntity = await countryRepository.Add(new Entities.CountryEntity { Name = "test" });
            lCreatedEntity.Name = "fred";

            // Act
            await countryRepository.Update(lCreatedEntity);

            // Assert
            var lResult = await countryRepository.GetById(lCreatedEntity.Id);
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("fred", lResult.Name);
        }

        [Test]
        public async Task GetCountries_GetsFromDb()
        {
            // Act
            await countryRepository.Add(                
                new CountryEntity { Name = "test" }
             );
            await countryRepository.Add(
                new CountryEntity { Name = "test2" }
             );
            await countryRepository.Add(
                new CountryEntity { Name = "test3" }
             );
            await countryRepository.Add(
                new CountryEntity { Name = "test4" }
             );

            // Assert
            var lResult = await countryRepository.GetCountries();
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Count == 4);
        }

        [Test]
        public async Task DeleteCountry_RemovesFromDb()
        {
            // Arrange
            var lCreatedEntity = await countryRepository.Add(new Entities.CountryEntity { Name = "test" });

            // Act
            await countryRepository.Delete(lCreatedEntity);

            // Assert
            var lResult = await countryRepository.GetById(lCreatedEntity.Id);
            Assert.IsNull(lResult);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }
    }
}
