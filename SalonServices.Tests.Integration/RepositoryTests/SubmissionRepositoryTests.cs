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
        public async Task GetSubmissionWithEntries_GetsFromDb()
        {
            // Arrange
            ImageEntity imageEntity = EntitiesHelper.GetImage();

            var lCreatedEntity = await submissionRepository.Add(new Entities.SubmissionEntity { Notes = "test", SalonYear = EntitiesHelper.GetSalonYear(), Person = EntitiesHelper.GetPerson(),
                Entries = new List<CompetitionEntryEntity>
                {
                    new CompetitionEntryEntity
                    {
                         Image = imageEntity,
                         Section = EntitiesHelper.GetSection(),
                         IsAccepted = true,
                         IsAwarded = false,
                         Score = 50
                    },
                    new CompetitionEntryEntity
                    {
                         Image = imageEntity,
                         Section = EntitiesHelper.GetSection(),
                    }
                }
            });

            // Act
            var lResult = await submissionRepository.GetSubmissionWithEntries(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("test", lResult.Notes);
            Assert.AreEqual(2, lResult.Entries.Count);
        }

        [Test]
        public async Task GetSubmissionResults_GetsFromDb()
        {
            // Arrange
            ImageEntity imageEntity = EntitiesHelper.GetImage();
            var lCreatedEntity = await submissionRepository.Add(new SubmissionEntity { Notes = "test", SalonYear = EntitiesHelper.GetSalonYear(), Person = EntitiesHelper.GetPerson(),
                Entries = new List<CompetitionEntryEntity>
                {
                    new CompetitionEntryEntity
                    {
                         Image = imageEntity,
                         Section = EntitiesHelper.GetSection(),
                         IsAccepted = true,
                         IsAwarded = false,
                         AwardDetails = "award 1",
                         Score = 50
                    },
                    new CompetitionEntryEntity
                    {
                         Image = imageEntity,
                         Section = EntitiesHelper.GetSection(),
                    }
                } });

            // Act
            var lResult = await submissionRepository.GetSubmissionResults(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.SubmissionId > 0);
            Assert.IsTrue(lResult.PersonId > 0);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(lResult.DisplayName));
            Assert.IsTrue(!string.IsNullOrWhiteSpace(lResult.Entries.ToList()[0].AwardDetails));
            Assert.IsTrue(lResult.Entries.Any(ent => ent.Id > 0 && ent.Score == 50 && ent.IsAwarded == false && ent.IsAccepted == true));
            Assert.IsTrue(lResult.Entries.Any(ent => ent.Id > 0 && !ent.Score.HasValue && !ent.IsAwarded.HasValue && !ent.IsAccepted.HasValue));
            Assert.IsTrue(lResult.Entries.All(ent => !string.IsNullOrWhiteSpace(ent.ImageName)));
        }

        [Test]
        public async Task GetBasicSubmissionInfoByPersonId_GetsFromDb()
        {
            // Arrange
            ImageEntity imageEntity = EntitiesHelper.GetImage();
            var personEntity = EntitiesHelper.GetPerson();
            await submissionRepository.Add(new SubmissionEntity
            {
                Notes = "test",
                SalonYear = EntitiesHelper.GetSalonYear(),
                Person = personEntity,
                Entries = new List<CompetitionEntryEntity>
                {
                    new CompetitionEntryEntity
                    {
                         Image = imageEntity,
                         Section = EntitiesHelper.GetSection(),
                         IsAccepted = true,
                         IsAwarded = false,
                         Score = 50
                    },
                    new CompetitionEntryEntity
                    {
                         Image = imageEntity,
                         Section = EntitiesHelper.GetSection(),
                    }
                }
            });

            await submissionRepository.Add(new SubmissionEntity
            {
                Notes = "test",
                SalonYear = EntitiesHelper.GetSalonYear(),
                Person = personEntity,
                Entries = new List<CompetitionEntryEntity>
                {
                    new CompetitionEntryEntity
                    {
                         Image = imageEntity,
                         Section = EntitiesHelper.GetSection(),
                         IsAccepted = true,
                         IsAwarded = false,
                         Score = 50
                    },
                    new CompetitionEntryEntity
                    {
                         Image = imageEntity,
                         Section = EntitiesHelper.GetSection(),
                    }
                }
            });

            // Act
            var lResult = await submissionRepository.GetBasicSubmissionInfoByPersonId(personEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count);
            Assert.IsTrue(lResult[0].SubmissionId > 0);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(lResult[0].DisplayName));
            Assert.AreEqual(2, lResult[0].NumberOfEntries);
        }

        [Test]
        public async Task UpdateSubmission_SetsNameAndEntryInDb()
        {
            // Arrange
            ImageEntity imageEntity = EntitiesHelper.GetImage();
            var lCreatedEntity = await submissionRepository.Add(new Entities.SubmissionEntity
            {
                Notes = "test",
                SalonYear = EntitiesHelper.GetSalonYear(),
                Person = EntitiesHelper.GetPerson(),
                Entries = new List<CompetitionEntryEntity>
                {
                    new CompetitionEntryEntity
                    {
                         Image = imageEntity,
                         Section = EntitiesHelper.GetSection(),
                         IsAccepted = true,
                         IsAwarded = false,
                         Score = 50
                    },
                    new CompetitionEntryEntity
                    {
                         Image = imageEntity,
                         Section = EntitiesHelper.GetSection(),
                    }
                }
            });
            lCreatedEntity.Notes = "fred";
            lCreatedEntity.Entries[0].IsAwarded = true;
            lCreatedEntity.Entries[0].Score = 100;

            lCreatedEntity.Entries[1].IsAccepted = false;
            lCreatedEntity.Entries[1].IsAwarded = false;
            lCreatedEntity.Entries[1].Score = 20;


            // Act
            await submissionRepository.Update(lCreatedEntity);

            // Assert
            var lResult = await submissionRepository.GetSubmissionWithEntries(lCreatedEntity.Id);
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("fred", lResult.Notes);
            Assert.AreEqual(100, lResult.Entries[0].Score);
            Assert.AreEqual(true, lResult.Entries[0].IsAccepted);
            Assert.AreEqual(true, lResult.Entries[0].IsAwarded);

            Assert.AreEqual(20, lResult.Entries[1].Score);
            Assert.AreEqual(false, lResult.Entries[1].IsAccepted);
            Assert.AreEqual(false, lResult.Entries[1].IsAwarded);
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
