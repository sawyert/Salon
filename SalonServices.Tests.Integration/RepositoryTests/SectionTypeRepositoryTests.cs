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
    public class SectionTypeRepositoryTests : AbstractDbTest<SalonDbContext>
    {
        private SectionTypeRepository sectionTypeRepository;

        [SetUp]
        public void Setup()
        {
            sectionTypeRepository = new SectionTypeRepository(base._DbContext);
        }

        [Test]
        public async Task AddSectionType_AddsToDb()
        {
            // Act
            var lResult = await sectionTypeRepository.Add(new SectionTypeEntity { Name = "test" });

            // Assert
            Assert.IsTrue(lResult.Id > 0);
            var lCreatedEntity = await sectionTypeRepository.GetById(lResult.Id);
            Assert.IsNotNull(lCreatedEntity);
            Assert.AreEqual("test", lCreatedEntity.Name);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }

        [Test]
        public async Task GetSectionType_GetsFromDb()
        {
            // Arrange
            var lCreatedEntity = await sectionTypeRepository.Add(new SectionTypeEntity { Name = "test" });

            // Act
            var lResult = await sectionTypeRepository.GetById(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("test", lResult.Name);
        }

        [Test]
        public async Task GetSectionTypes_GetsFromDb()
        {
            // Arrange
            await sectionTypeRepository.Add(new SectionTypeEntity { Name = "test1" });
            await sectionTypeRepository.Add(new SectionTypeEntity { Name = "test2" });

            // Act
            var lResult = await sectionTypeRepository.GetAll();

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count(t => t.Name.StartsWith("test")));
        }

        [Test]
        public async Task UpdateSectionType_SetsNameInDb()
        {
            // Arrange
            var lCreatedEntity = await sectionTypeRepository.Add(new SectionTypeEntity { Name = "test" });
            lCreatedEntity.Name = "fred";

            // Act
            await sectionTypeRepository.Update(lCreatedEntity);

            // Assert
            var lResult = await sectionTypeRepository.GetById(lCreatedEntity.Id);
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("fred", lResult.Name);
        }
        
        [Test]
        public async Task DeleteSectionType_RemovesFromDb()
        {
            // Arrange
            var lCreatedEntity = await sectionTypeRepository.Add(new SectionTypeEntity { Name = "test" });

            // Act
            await sectionTypeRepository.Delete(lCreatedEntity);

            // Assert
            var lResult = await sectionTypeRepository.GetById(lCreatedEntity.Id);
            Assert.IsNull(lResult);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }
    }
}
