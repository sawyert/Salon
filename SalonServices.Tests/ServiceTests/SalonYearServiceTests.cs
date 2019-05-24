using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using SalonServices.Dto.Submission;
using SalonServices.Entities;
using SalonServices.Mappings;
using SalonServices.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Tests.Unit.ServiceTests
{
    [TestFixture]
    public class SalonYearServiceTests
    {
        private ISalonRepository salonRepository;
        private ISalonYearRepository salonYearRepository;
        private ICountryRepository countryRepository;
        private SalonYearService salonYearService;

        [SetUp]
        public void Setup()
        {
            this.salonRepository = Substitute.For<ISalonRepository>();
            this.salonYearRepository = Substitute.For<ISalonYearRepository>();
            this.countryRepository = Substitute.For<ICountryRepository>();
            this.salonYearService = new SalonYearService(this.salonRepository, this.salonYearRepository, this.countryRepository);

            Mapping.CreateConfiguration();
        }
        private static SalonEntity GetSalon()
        {
            return new SalonEntity
            {
                Name = "this name",
                Website = "web",
                Country = GetCountry(),
                Id = 7
            };
        }

        private static CountryEntity GetCountry()
        {
            return new CountryEntity
            {
                Name = "country 1",
                Id = 4
            };
        }

        private static PhotoOrganisationEntity GetPhotoOrganisation()
        {
            return new PhotoOrganisationEntity
            {
                Name = "org",
                Id = 5
            };
        }

        [Test]
        public async Task GetFullSalonInformation_GetsInfoFromDb()
        {
            // Arrange
            var expected = new List<FullSalonInformationDto>
            {
                new FullSalonInformationDto
                {
                    CountryId = 1,
                    CountryName = "test",
                    SalonId = 5,
                    SalonName = "salon name",
                    Website = "test1"
                },
                new FullSalonInformationDto
                {
                    CountryId = 1,
                    CountryName = "test",
                    SalonId = 5,
                    SalonName = "salon name",
                    Website = "test1"
                }
            };

            this.salonRepository.GetFullSalonInformation().Returns(expected);

            // Act
            var lResult = await this.salonYearService.GetFullSalonInformation();

            // Assert
            expected.ShouldBeEquivalentTo(lResult);
        }

        [Test]
        public async Task GetSalonYears_GetsInfoFromDbAndMaps()
        {
            // Arrange
            this.salonYearRepository.GetSalonYearsWithAccreditations(2017).Returns(new List<SalonYearEntity> { new SalonYearEntity
                {
                    Name = "test1",
                    Salon = GetSalon(),
                    Accreditations = new List<AccreditationEntity> {
                    new AccreditationEntity { SalonNumber = "1", PhotoOrganisation = GetPhotoOrganisation() },
                    new AccreditationEntity { SalonNumber = "2", PhotoOrganisation = GetPhotoOrganisation() } }
                },
                new SalonYearEntity
                {
                    Name = "test1",
                    Salon = GetSalon(),
                    Accreditations = new List<AccreditationEntity> { }
                }
            });

            // Act
            var lResult = await this.salonYearService.GetSalonYears(2017);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count);
            Assert.AreEqual(2, lResult[0].Accreditations.Count);
        }

        [Test]
        public async Task CreateSalon_CreatesCountryIfEmpty()
        {
            // Arrange
            this.salonRepository.Add(Arg.Any<SalonEntity>()).Returns(new SalonEntity
            {
                Id = 50,
                Name = "salon"
            });

            // Act
            var lResult = await this.salonYearService.CreateSalon(new CreateSalonDto { CountryName = "UK", SalonName = "sal name" });

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(50, lResult.SalonId);
            await this.salonRepository.Received(1).Add(Arg.Is<SalonEntity>(se => se.Country != null && se.Country.Name == "UK" && se.Name == "sal name"));
        }

        [Test]
        public async Task CreateSalon_DoesntCreateCountryIfIdExists()
        {
            // Arrange
            this.salonRepository.Add(Arg.Any<SalonEntity>()).Returns(new SalonEntity
            {
                Id = 50,
                Name = "salon"
            });

            // Act
            var lResult = await this.salonYearService.CreateSalon(new CreateSalonDto { CountryId = 40, SalonName = "sal name" });

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(50, lResult.SalonId);
            await this.salonRepository.Received(1).Add(Arg.Is<SalonEntity>(se => se.Country == null && se.CountryId == 40 && se.Name == "sal name"));
        }

        [Test]
        public async Task CreateSalonYear_AddsToDb()
        {
            // Arrange
            this.salonYearRepository.Add(Arg.Any<SalonYearEntity>()).Returns(new SalonYearEntity
            {
                Id = 50,
                Name = "salon",
                SalonId = 60
            });

            // Act
            var lResult = await this.salonYearService.CreateSalonYear(new CreateSalonYearDto { SalonId = 40, Name = "sal name", Year = 3000 });

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(50, lResult.Id);
            Assert.AreEqual(60, lResult.SalonId);
            await this.salonYearRepository.Received(1).Add(Arg.Is<SalonYearEntity>(se => se.SalonId == 40 && se.Name == "sal name" && se.Year == 3000));
        }
    }
}
