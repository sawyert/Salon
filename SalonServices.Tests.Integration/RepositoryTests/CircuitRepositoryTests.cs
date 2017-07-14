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
    public class CircuitRepositoryTests : AbstractDbTest<SalonDbContext>
    {
        private CircuitRepository circuitRepository;

        [SetUp]
        public void Setup()
        {
            circuitRepository = new CircuitRepository(base._DbContext);
        }

        [Test]
        public async Task AddCircuit_AddsToDb()
        {
            // Act
            var lResult = await circuitRepository.Add(new CircuitEntity { Name = "test" });

            // Assert
            Assert.IsTrue(lResult.Id > 0);
            var lCreatedEntity = await circuitRepository.GetById(lResult.Id);
            Assert.IsNotNull(lCreatedEntity);
            Assert.AreEqual("test", lCreatedEntity.Name);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }

        [Test]
        public async Task GetCircuit_GetsFromDb()
        {
            // Arrange
            var lCreatedEntity = await circuitRepository.Add(new CircuitEntity { Name = "test" });

            // Act
            var lResult = await circuitRepository.GetById(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("test", lResult.Name);
        }

        [Test]
        public async Task GetCircuits_GetsFromDb()
        {
            // Arrange
            await circuitRepository.Add(new CircuitEntity { Name = "test1" });
            await circuitRepository.Add(new CircuitEntity { Name = "test2" });

            // Act
            var lResult = await circuitRepository.GetAll();

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count(t => t.Name.StartsWith("test")));
        }

        [Test]
        public async Task UpdateCircuit_SetsNameInDb()
        {
            // Arrange
            var lCreatedEntity = await circuitRepository.Add(new CircuitEntity { Name = "test" });
            lCreatedEntity.Name = "fred";

            // Act
            await circuitRepository.Update(lCreatedEntity);

            // Assert
            var lResult = await circuitRepository.GetById(lCreatedEntity.Id);
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("fred", lResult.Name);
        }
        
        [Test]
        public async Task DeleteCircuit_RemovesFromDb()
        {
            // Arrange
            var lCreatedEntity = await circuitRepository.Add(new CircuitEntity { Name = "test" });

            // Act
            await circuitRepository.Delete(lCreatedEntity);

            // Assert
            var lResult = await circuitRepository.GetById(lCreatedEntity.Id);
            Assert.IsNull(lResult);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }
    }
}
