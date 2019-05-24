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
    public class PersonRepositoryTests : AbstractDbTest<SalonDbContext>
    {
        private PersonRepository personRepository;

        [SetUp]
        public void Setup()
        {
            personRepository = new PersonRepository(base._DbContext);
        }

        [Test]
        public async Task AddPerson_AddsToDb()
        {
            // Act
            var lResult = await personRepository.Add(new Entities.PersonEntity { Name = "test" });

            // Assert
            Assert.IsTrue(lResult.Id > 0);
            var lCreatedEntity = await personRepository.GetById(lResult.Id);
            Assert.IsNotNull(lCreatedEntity);
            Assert.AreEqual("test", lCreatedEntity.Name);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }

        [Test]
        public async Task GetPerson_GetsFromDb()
        {
            // Arrange
            var lCreatedEntity = await personRepository.Add(new Entities.PersonEntity { Name = "test"});

            // Act
            var lResult = await personRepository.GetById(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("test", lResult.Name);
        }

        [Test]
        public async Task UpdatePerson_SetsNameInDb()
        {
            // Arrange
            var lCreatedEntity = await personRepository.Add(new Entities.PersonEntity { Name = "test" });
            lCreatedEntity.Name = "fred";

            // Act
            await personRepository.Update(lCreatedEntity);

            // Assert
            var lResult = await personRepository.GetById(lCreatedEntity.Id);
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("fred", lResult.Name);
        }
        
        [Test]
        public async Task DeletePerson_RemovesFromDb()
        {
            // Arrange
            var lCreatedEntity = await personRepository.Add(new Entities.PersonEntity { Name = "test" });

            // Act
            await personRepository.Delete(lCreatedEntity);

            // Assert
            var lResult = await personRepository.GetById(lCreatedEntity.Id);
            Assert.IsNull(lResult);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }

        [Test]
        public async Task GetAll_GetsFromDb()
        {
            // Arrange
            var lCreatedEntity1 = await personRepository.Add(new PersonEntity { Name = "test1" });
            var lCreatedEntity2 = await personRepository.Add(new PersonEntity { Name = "test2" });

            // Act
            var lResults = await personRepository.GetAll();

            // Assert
            Assert.IsNotNull(lResults);
            Assert.AreEqual(2, lResults.Count(t => t.Name.StartsWith("test")));
        }

        [Test]
        public async Task GetWithSubmissionsSalonsAccreditationSections_GetsFromDb()
        {
            // Arrange
            var lSalonYear = EntitiesHelper.GetSalonYear();
            lSalonYear.Accreditations = new List<AccreditationEntity> { new AccreditationEntity { SalonNumber = "test", PhotoOrganisation = EntitiesHelper.GetPhotoOrganisation() } };
            var lSection = EntitiesHelper.GetSection();
            lSection.SalonYear = lSalonYear;
            var lSubmission = new SubmissionEntity { SalonYear = lSalonYear, Entries = new List<CompetitionEntryEntity> { new CompetitionEntryEntity { Image = EntitiesHelper.GetImage(), Section =  lSection } } };
            var lCreatedEntity = await personRepository.Add(new PersonEntity { Name = "test1", Submissions = new List<SubmissionEntity> { lSubmission } });

            // Act
            var lResult = await personRepository.GetWithSubmissionsSalonsAccreditationSections(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsNotNull(lResult.Submissions);
            Assert.IsTrue(lResult.Submissions.Any());
            Assert.IsNotNull(lResult.Submissions[0].Entries);
            Assert.IsTrue(lResult.Submissions[0].Entries.Any());
            Assert.IsNotNull(lResult.Submissions[0].Entries[0].Section);
            Assert.IsNotNull(lResult.Submissions[0].Entries[0].Section.SectionType);
            Assert.IsNotNull(lResult.Submissions[0].Entries[0].Section.SalonYear);
            Assert.IsNotNull(lResult.Submissions[0].Entries[0].Section.SalonYear.Accreditations);
            Assert.IsTrue(lResult.Submissions[0].Entries[0].Section.SalonYear.Accreditations.Any());
            Assert.IsNotNull(lResult.Submissions[0].Entries[0].Section.SalonYear.Salon);
        }
    }
}
