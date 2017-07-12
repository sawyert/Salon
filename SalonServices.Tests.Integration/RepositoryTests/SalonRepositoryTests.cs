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
    public class SalonRepositoryTests : AbstractDbTest<SalonDbContext>
    {
        private SalonRepository salonRepository;

        [SetUp]
        public void Setup()
        {
            salonRepository = new SalonRepository(base._DbContext);
        }

        [Test]
        public async Task AddSalon_AddsToDb()
        {
            // Act
            var lResult = await salonRepository.Add(new Entities.SalonEntity { Name = "test", Country = EntitiesHelper.GetCountry() });

            // Assert
            Assert.IsTrue(lResult.Id > 0);
            var lCreatedEntity = await salonRepository.GetById(lResult.Id);
            Assert.IsNotNull(lCreatedEntity);
            Assert.AreEqual("test", lCreatedEntity.Name);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }

        [Test]
        public async Task GetSalon_GetsFromDb()
        {
            // Arrange
            var lCreatedEntity = await salonRepository.Add(new Entities.SalonEntity { Name = "test", Country = EntitiesHelper.GetCountry() });

            // Act
            var lResult = await salonRepository.GetById(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("test", lResult.Name);
        }

        [Test]
        public async Task UpdateSalon_SetsNameInDb()
        {
            // Arrange
            var lCreatedEntity = await salonRepository.Add(new Entities.SalonEntity { Name = "test", Country = EntitiesHelper.GetCountry() });
            lCreatedEntity.Name = "fred";

            // Act
            await salonRepository.Update(lCreatedEntity);

            // Assert
            var lResult = await salonRepository.GetById(lCreatedEntity.Id);
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("fred", lResult.Name);
        }
        
        [Test]
        public async Task DeleteSalon_RemovesFromDb()
        {
            // Arrange
            var lCreatedEntity = await salonRepository.Add(new Entities.SalonEntity { Name = "test", Country = EntitiesHelper.GetCountry() });

            // Act
            await salonRepository.Delete(lCreatedEntity);

            // Assert
            var lResult = await salonRepository.GetById(lCreatedEntity.Id);
            Assert.IsNull(lResult);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }
    }
}
