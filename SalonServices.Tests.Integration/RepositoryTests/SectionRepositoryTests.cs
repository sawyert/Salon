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
    public class SectionRepositoryTests : AbstractDbTest<SalonDbContext>
    {
        private SectionRepository sectionRepository;

        [SetUp]
        public void Setup()
        {
            sectionRepository = new SectionRepository(base._DbContext);
        }

        [Test]
        public async Task AddSection_AddsToDb()
        {
            // Act
            var lResult = await sectionRepository.Add(new Entities.SectionEntity { SalonYear = EntitiesHelper.GetSalonYear(), SectionType = EntitiesHelper.GetSectionType() });

            // Assert
            Assert.IsTrue(lResult.Id > 0);
            var lCreatedEntity = await sectionRepository.GetById(lResult.Id);
            Assert.IsNotNull(lCreatedEntity);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }

        [Test]
        public async Task GetSection_GetsFromDb()
        {
            // Arrange
            var lCreatedEntity = await sectionRepository.Add(new Entities.SectionEntity { SalonYear = EntitiesHelper.GetSalonYear(), SectionType = EntitiesHelper.GetSectionType() });

            // Act
            var lResult = await sectionRepository.GetById(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
        }

        [Test]
        public async Task GetSectionsBySalonYearSectionTypeIds_GetsFromDb()
        {
            // Arrange
            var salonYear = EntitiesHelper.GetSalonYear();
            var sectionType1 = EntitiesHelper.GetSectionType();
            var sectionType2 = EntitiesHelper.GetSectionType();
            var lCreatedEntity1 = await sectionRepository.Add(new Entities.SectionEntity { SalonYear = salonYear, SectionType = sectionType1 });
            var lCreatedEntity2 = await sectionRepository.Add(new Entities.SectionEntity { SalonYear = salonYear, SectionType = sectionType2 });
            var lCreatedEntity3 = await sectionRepository.Add(new Entities.SectionEntity { SalonYear = EntitiesHelper.GetSalonYear(), SectionType = sectionType2 });
            var lCreatedEntity4 = await sectionRepository.Add(new Entities.SectionEntity { SalonYear = salonYear, SectionType = EntitiesHelper.GetSectionType() });


            // Act
            var lResult = await sectionRepository.GetSectionsBySalonYearSectionTypeIds(salonYear.Id, new List<int> { sectionType1.Id, sectionType2.Id });

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count);
        }

        [Test]
        public async Task UpdateSection_SetsNameInDb()
        {
            // Arrange
            var lCreatedEntity = await sectionRepository.Add(new Entities.SectionEntity { SalonYear = EntitiesHelper.GetSalonYear(), SectionType = EntitiesHelper.GetSectionType() });
            var lNewSalonYear = EntitiesHelper.GetSalonYear();
            lNewSalonYear.Name = "new salon year";
            lCreatedEntity.SalonYear = lNewSalonYear;

            // Act
            await sectionRepository.Update(lCreatedEntity);

            // Assert
            var lResult = await sectionRepository.GetById(lCreatedEntity.Id);
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("new salon year", lResult.SalonYear.Name);
        }

        [Test]
        public async Task DeleteSection_RemovesFromDb()
        {
            // Arrange
            var lCreatedEntity = await sectionRepository.Add(new Entities.SectionEntity { SalonYear = EntitiesHelper.GetSalonYear(), SectionType = EntitiesHelper.GetSectionType() });

            // Act
            await sectionRepository.Delete(lCreatedEntity);

            // Assert
            var lResult = await sectionRepository.GetById(lCreatedEntity.Id);
            Assert.IsNull(lResult);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }
    }
}
