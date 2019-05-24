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
    public class AccreditationRepositoryTests : AbstractDbTest<SalonDbContext>
    {
        private AccreditationRepository accreditationRepository;

        [SetUp]
        public void Setup()
        {
            accreditationRepository = new AccreditationRepository(base._DbContext);
        }
                
        [Test]
        public async Task AddAccreditation_AddsToDb()
        {
            // Act
            var lResult = await accreditationRepository.Add(new Entities.AccreditationEntity { SalonNumber = "test", SalonYear = EntitiesHelper.GetSalonYear(), PhotoOrganisation = new PhotoOrganisationEntity { Name = "org1" } });

            // Assert
            Assert.IsTrue(lResult.Id > 0);
            var lCreatedEntity = await accreditationRepository.GetById(lResult.Id);
            Assert.IsNotNull(lCreatedEntity);
            Assert.AreEqual("test", lCreatedEntity.SalonNumber);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }

        [Test]
        public async Task GetAccreditation_GetsFromDb()
        {
            // Arrange
            var lCreatedEntity = await accreditationRepository.Add(new Entities.AccreditationEntity { SalonNumber = "test", SalonYear = EntitiesHelper.GetSalonYear(), PhotoOrganisation = new PhotoOrganisationEntity { Name = "org1" } });

            // Act
            var lResult = await accreditationRepository.GetById(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("test", lResult.SalonNumber);
        }

        [Test]
        public async Task UpdateAccreditation_SetsSalonNumberInDb()
        {
            // Arrange
            var lCreatedEntity = await accreditationRepository.Add(new Entities.AccreditationEntity { SalonNumber = "test", SalonYear = EntitiesHelper.GetSalonYear(), PhotoOrganisation = new PhotoOrganisationEntity { Name = "org1" } });
            lCreatedEntity.SalonNumber = "fred";

            // Act
            await accreditationRepository.Update(lCreatedEntity);

            // Assert
            var lResult = await accreditationRepository.GetById(lCreatedEntity.Id);
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("fred", lResult.SalonNumber);
        }
        
        [Test]
        public async Task DeleteAccreditation_RemovesFromDb()
        {
            // Arrange
            var lCreatedEntity = await accreditationRepository.Add(new Entities.AccreditationEntity { SalonNumber = "test", SalonYear = EntitiesHelper.GetSalonYear(), PhotoOrganisation = new PhotoOrganisationEntity { Name = "org1" } });

            // Act
            await accreditationRepository.Delete(lCreatedEntity);

            // Assert
            var lResult = await accreditationRepository.GetById(lCreatedEntity.Id);
            Assert.IsNull(lResult);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }
    }
}
