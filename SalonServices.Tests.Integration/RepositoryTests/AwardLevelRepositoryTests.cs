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
    public class AwardLevelRepositoryTests : AbstractDbTest<SalonDbContext>
    {
        private AwardLevelRepository awardLevelRepository;

        [SetUp]
        public void Setup()
        {
            awardLevelRepository = new AwardLevelRepository(base._DbContext);
        }

        [Test]
        public async Task AddAwardLevel_AddsToDb()
        {
            // Act
            var lResult = await awardLevelRepository.Add(new Entities.AwardLevelEntity { Name = "test", PhotoOrganisation = new PhotoOrganisationEntity { Name = "org1" } });

            // Assert
            Assert.IsTrue(lResult.Id > 0);
            var lCreatedEntity = await awardLevelRepository.GetById(lResult.Id);
            Assert.IsNotNull(lCreatedEntity);
            Assert.AreEqual("test", lCreatedEntity.Name);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }

        [Test]
        public async Task GetAwardLevel_GetsFromDb()
        {
            // Arrange
            var lCreatedEntity = await awardLevelRepository.Add(new Entities.AwardLevelEntity { Name = "test", PhotoOrganisation = new PhotoOrganisationEntity { Name = "org1" } });

            // Act
            var lResult = await awardLevelRepository.GetById(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("test", lResult.Name);
        }

        [Test]
        public async Task UpdateAwardLevel_SetsNameInDb()
        {
            // Arrange
            var lCreatedEntity = await awardLevelRepository.Add(new Entities.AwardLevelEntity { Name = "test", PhotoOrganisation = new PhotoOrganisationEntity { Name = "org1" } });
            lCreatedEntity.Name = "fred";

            // Act
            await awardLevelRepository.Update(lCreatedEntity);

            // Assert
            var lResult = await awardLevelRepository.GetById(lCreatedEntity.Id);
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("fred", lResult.Name);
        }
        
        [Test]
        public async Task DeleteAwardLevel_RemovesFromDb()
        {
            // Arrange
            var lCreatedEntity = await awardLevelRepository.Add(new Entities.AwardLevelEntity { Name = "test", PhotoOrganisation = new PhotoOrganisationEntity { Name = "org1" } });

            // Act
            await awardLevelRepository.Delete(lCreatedEntity);

            // Assert
            var lResult = await awardLevelRepository.GetById(lCreatedEntity.Id);
            Assert.IsNull(lResult);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }
    }
}
