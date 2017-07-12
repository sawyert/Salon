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
    public class SubmissionRepositoryTests : AbstractDbTest<SalonDbContext>
    {
        private SubmissionRepository submissionRepository;

        [SetUp]
        public void Setup()
        {
            submissionRepository = new SubmissionRepository(base._DbContext);
        }

        [Test]
        public async Task AddSubmission_AddsToDb()
        {
            // Act
            var lResult = await submissionRepository.Add(new SubmissionEntity { Notes = "test", SalonYear = EntitiesHelper.GetSalonYear(), Person = EntitiesHelper.GetPerson() });

            // Assert
            Assert.IsTrue(lResult.Id > 0);
            var lCreatedEntity = await submissionRepository.GetById(lResult.Id);
            Assert.IsNotNull(lCreatedEntity);
            Assert.AreEqual("test", lCreatedEntity.Notes);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }

        [Test]
        public async Task GetSubmission_GetsFromDb()
        {
            // Arrange
            var lCreatedEntity = await submissionRepository.Add(new Entities.SubmissionEntity { Notes = "test", SalonYear = EntitiesHelper.GetSalonYear(), Person = EntitiesHelper.GetPerson() });

            // Act
            var lResult = await submissionRepository.GetById(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("test", lResult.Notes);
        }

        [Test]
        public async Task UpdateSubmission_SetsNameInDb()
        {
            // Arrange
            var lCreatedEntity = await submissionRepository.Add(new Entities.SubmissionEntity { Notes = "test", SalonYear = EntitiesHelper.GetSalonYear(), Person = EntitiesHelper.GetPerson() });
            lCreatedEntity.Notes = "fred";

            // Act
            await submissionRepository.Update(lCreatedEntity);

            // Assert
            var lResult = await submissionRepository.GetById(lCreatedEntity.Id);
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("fred", lResult.Notes);
        }
        
        [Test]
        public async Task DeleteSubmission_RemovesFromDb()
        {
            // Arrange
            var lCreatedEntity = await submissionRepository.Add(new Entities.SubmissionEntity { Notes = "test", SalonYear = EntitiesHelper.GetSalonYear(), Person = EntitiesHelper.GetPerson() });

            // Act
            await submissionRepository.Delete(lCreatedEntity);

            // Assert
            var lResult = await submissionRepository.GetById(lCreatedEntity.Id);
            Assert.IsNull(lResult);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }
    }
}
