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
            this.salonYearRepository.GetSalonYearsWithAccreditations().Returns(new List<SalonYearEntity> { new SalonYearEntity
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
            var lResult = await this.salonYearService.GetSalonYears();

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count);
            Assert.AreEqual(2, lResult[0].Accreditations.Count);
        }
    }
}
