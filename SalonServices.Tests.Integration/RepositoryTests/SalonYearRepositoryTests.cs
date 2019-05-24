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
    public class SalonYearRepositoryTests : AbstractDbTest<SalonDbContext>
    {
        private SalonYearRepository salonYearRepository;

        [SetUp]
        public void Setup()
        {
            salonYearRepository = new SalonYearRepository(base._DbContext);
        }

        [Test]
        public async Task AddSalonYear_AddsToDb()
        {
            // Act
            var lResult = await salonYearRepository.Add(new Entities.SalonYearEntity { Name = "test", Salon = EntitiesHelper.GetSalon() });

            // Assert
            Assert.IsTrue(lResult.Id > 0);
            var lCreatedEntity = await salonYearRepository.GetById(lResult.Id);
            Assert.IsNotNull(lCreatedEntity);
            Assert.AreEqual("test", lCreatedEntity.Name);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }

        [Test]
        public async Task GetSalonYear_GetsFromDb()
        {
            // Arrange
            var lCreatedEntity = await salonYearRepository.Add(new Entities.SalonYearEntity { Name = "test", Salon = EntitiesHelper.GetSalon() });

            // Act
            var lResult = await salonYearRepository.GetById(lCreatedEntity.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("test", lResult.Name);
        }

        [Test]
        public async Task GetSalonYearsWithAccreditations_GetsFromDb()
        {
            // Arrange
            await salonYearRepository.Add(new SalonYearEntity
            {
                Name = "test1",
                Year = 2017,
                Salon = EntitiesHelper.GetSalon(),
                Accreditations = new List<AccreditationEntity> {
                new AccreditationEntity { SalonNumber = "1", PhotoOrganisation = EntitiesHelper.GetPhotoOrganisation() },
                new AccreditationEntity { SalonNumber = "1", PhotoOrganisation = EntitiesHelper.GetPhotoOrganisation() } }
            });
            await salonYearRepository.Add(new SalonYearEntity
            {
                Name = "test2",
                Year = 2016,
                Salon = EntitiesHelper.GetSalon(),
                Accreditations = new List<AccreditationEntity> { }
            });
            await salonYearRepository.Add(new SalonYearEntity
            {
                Name = "test3",
                Year = 2017,
                Salon = EntitiesHelper.GetSalon(),
                Accreditations = new List<AccreditationEntity> { }
            });

            // Act
            var lResult = await salonYearRepository.GetSalonYearsWithAccreditations(2017);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count(t => t.Name.StartsWith("test")));
            Assert.AreEqual(2, lResult.Where(t => t.Name.StartsWith("test")).ToList()[0].Accreditations.Count);
        }

        [Test]
        public async Task GetSalonYearsIdsByCircuitId_GetsFromDb()
        {
            // Arrange
            var circuit = new CircuitEntity { Name = "circuitName" };
            await salonYearRepository.Add(new SalonYearEntity
            {
                Name = "test1",
                Year = 2017,
                Salon = EntitiesHelper.GetSalon(),
                Circuit = circuit
            });
            await salonYearRepository.Add(new SalonYearEntity
            {
                Name = "test2",
                Year = 2016,
                Salon = EntitiesHelper.GetSalon(),
                Circuit = circuit
            });
            await salonYearRepository.Add(new SalonYearEntity
            {
                Name = "test3",
                Year = 2017,
                Salon = EntitiesHelper.GetSalon(),
                Circuit = new CircuitEntity { Name = "circuitName2" }
            });

            // Act
            var lResult = await salonYearRepository.GetSalonYearsIdsByCircuitId(circuit.Id);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count());
        }

        [Test]
        public async Task UpdateSalonYear_SetsNameInDb()
        {
            // Arrange
            var lCreatedEntity = await salonYearRepository.Add(new Entities.SalonYearEntity { Name = "test", Salon = EntitiesHelper.GetSalon() });
            lCreatedEntity.Name = "fred";

            // Act
            await salonYearRepository.Update(lCreatedEntity);

            // Assert
            var lResult = await salonYearRepository.GetById(lCreatedEntity.Id);
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.Id > 0);
            Assert.AreEqual("fred", lResult.Name);
        }

        [Test]
        public async Task DeleteSalonYear_RemovesFromDb()
        {
            // Arrange
            var lCreatedEntity = await salonYearRepository.Add(new Entities.SalonYearEntity { Name = "test", Salon = EntitiesHelper.GetSalon() });

            // Act
            await salonYearRepository.Delete(lCreatedEntity);

            // Assert
            var lResult = await salonYearRepository.GetById(lCreatedEntity.Id);
            Assert.IsNull(lResult);
            Assert.IsTrue(lCreatedEntity.Id > 0);
        }
    }
}
