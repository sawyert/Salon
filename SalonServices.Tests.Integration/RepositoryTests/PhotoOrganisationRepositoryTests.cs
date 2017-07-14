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
    public class PhotoOrganisationRepositoryTests : AbstractDbTest<SalonDbContext>
    {
        private PhotoOrganisationRepository photoOrganisationRepository;

        [SetUp]
        public void Setup()
        {
            photoOrganisationRepository = new PhotoOrganisationRepository(base._DbContext);
        }

        [Test]
        public async Task AddPhotoOrganisation_AddsToDb()
        {
            // Act
            var lResult = await photoOrganisationRepository.Add(new PhotoOrganisationEntity { Name = "test" });

            // Assert
            Assert.IsTrue(lResult.Id > 0);
            var lCreatedEntity = await photoOrganisationRepository.GetById(lResult.Id);
            Assert.IsNotNull(lCreatedEntity);
            Assert.AreEqual("test", lCreatedEntity.Name);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }

        [Test]
        public async Task GetPhotoOrganisation_GetsFromDb()
        {
            // Arrange
            var lCreatedEntity = await photoOrganisationRepository.Add(new PhotoOrganisationEntity { Name = "test" });

            // Act
            var lResult = await photoOrganisationRepository.GetById(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("test", lResult.Name);
        }

        [Test]
        public async Task GetPhotoOrganisations_GetsFromDb()
        {
            // Arrange
            await photoOrganisationRepository.Add(new PhotoOrganisationEntity { Name = "test1" });
            await photoOrganisationRepository.Add(new PhotoOrganisationEntity { Name = "test2" });

            // Act
            var lResult = await photoOrganisationRepository.GetAllBasic();

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count(t => t.Name.StartsWith("test")));
        }

        [Test]
        public async Task UpdatePhotoOrganisation_SetsNameInDb()
        {
            // Arrange
            var lCreatedEntity = await photoOrganisationRepository.Add(new PhotoOrganisationEntity { Name = "test" });
            lCreatedEntity.Name = "fred";

            // Act
            await photoOrganisationRepository.Update(lCreatedEntity);

            // Assert
            var lResult = await photoOrganisationRepository.GetById(lCreatedEntity.Id);
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("fred", lResult.Name);
        }
        
        [Test]
        public async Task DeletePhotoOrganisation_RemovesFromDb()
        {
            // Arrange
            var lCreatedEntity = await photoOrganisationRepository.Add(new PhotoOrganisationEntity { Name = "test" });

            // Act
            await photoOrganisationRepository.Delete(lCreatedEntity);

            // Assert
            var lResult = await photoOrganisationRepository.GetById(lCreatedEntity.Id);
            Assert.IsNull(lResult);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }

        [Test]
        public async Task GetPhotoOrganisationsWithAwards_GetsFromDb()
        {
            // Arrange
            var lCreatedEntity1 = await photoOrganisationRepository.Add(new PhotoOrganisationEntity { Name = "test", AwardLevels = new List<AwardLevelEntity> { new AwardLevelEntity {  Name = "award 1" }, new AwardLevelEntity { Name = "award 2" } } });
            var lCreatedEntity2 = await photoOrganisationRepository.Add(new PhotoOrganisationEntity { Name = "test2", AwardLevels = new List<AwardLevelEntity> { new AwardLevelEntity { Name = "award 3" }, new AwardLevelEntity { Name = "award 4" }, new AwardLevelEntity { Name = "award 5" } } });

            // Act
            var lResults = await photoOrganisationRepository.GetAllWithAwards();

            // Assert
            Assert.IsNotNull(lResults);
            Assert.IsTrue(lResults.Count > 1);
            Assert.IsTrue(lResults.Any(t => t.Name == "test" && t.AwardLevels.Count == 2));
            Assert.IsTrue(lResults.Any(t => t.Name == "test2" && t.AwardLevels.Count == 3));
        }
    }
}
