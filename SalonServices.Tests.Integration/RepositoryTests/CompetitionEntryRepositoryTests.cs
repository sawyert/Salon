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
    public class CompetitionEntryRepositoryTests : AbstractDbTest<SalonDbContext>
    {
        private CompetitionEntryRepository competitionEntryRepository;

        [SetUp]
        public void Setup()
        {
            competitionEntryRepository = new CompetitionEntryRepository(base._DbContext);
        }

        

        [Test]
        public async Task AddCompetitionEntry_AddsToDb()
        {
            // Act
            var lResult = await competitionEntryRepository.Add(new Entities.CompetitionEntryEntity { Score = 50, Image = EntitiesHelper.GetImage(), Section = EntitiesHelper.GetSection() });

            // Assert
            Assert.IsTrue(lResult.Id > 0);
            var lCreatedEntity = await competitionEntryRepository.GetById(lResult.Id);
            Assert.IsNotNull(lCreatedEntity);
            Assert.AreEqual(50, lCreatedEntity.Score);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }

        [Test]
        public async Task GetCompetitionEntry_GetsFromDb()
        {
            // Arrange
            var lCreatedEntity = await competitionEntryRepository.Add(new Entities.CompetitionEntryEntity { Score = 50, Image = EntitiesHelper.GetImage(), Section = EntitiesHelper.GetSection() });

            // Act
            var lResult = await competitionEntryRepository.GetById(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual(50, lResult.Score);

        }

        [Test]
        public async Task UpdateCompetitionEntry_SetsScoreInDb()
        {
            // Arrange
            var lCreatedEntity = await competitionEntryRepository.Add(new Entities.CompetitionEntryEntity { Score = 50, Image = EntitiesHelper.GetImage(), Section = EntitiesHelper.GetSection() });
            lCreatedEntity.Score = 70;

            // Act
            await competitionEntryRepository.Update(lCreatedEntity);

            // Assert
            var lResult = await competitionEntryRepository.GetById(lCreatedEntity.Id);
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual(70, lResult.Score);
        }
        
        [Test]
        public async Task DeleteCompetitionEntry_RemovesFromDb()
        {
            // Arrange
            var lCreatedEntity = await competitionEntryRepository.Add(new Entities.CompetitionEntryEntity { Score = 50, Image = EntitiesHelper.GetImage(), Section = EntitiesHelper.GetSection() });

            // Act
            await competitionEntryRepository.Delete(lCreatedEntity);

            // Assert
            var lResult = await competitionEntryRepository.GetById(lCreatedEntity.Id);
            Assert.IsNull(lResult);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }
    }
}
