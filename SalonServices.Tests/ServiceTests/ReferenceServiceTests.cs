using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using SalonServices.Dto;
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
    public class ReferenceServiceTests
    {
        private ICountryRepository _referenceRepository;
        private ISectionTypeRepository _sectionTypeRepository;
        private IPhotoOrganisationRepository _photoOrganisationRepository;
        private ICircuitRepository _circuitRepository;
        private ReferenceServices referenceServices;

        [SetUp]
        public void Setup()
        {
            this._referenceRepository = Substitute.For<ICountryRepository>();
            this._sectionTypeRepository = Substitute.For<ISectionTypeRepository>();
            this._photoOrganisationRepository = Substitute.For<IPhotoOrganisationRepository>();
            this._circuitRepository = Substitute.For<ICircuitRepository>();

            this.referenceServices = new ReferenceServices(this._referenceRepository, this._sectionTypeRepository, this._photoOrganisationRepository, this._circuitRepository);

            Mapping.CreateConfiguration();
        }
        
      
        [Test]
        public async Task GetOrgs_GetsInfoFromDbAndMaps()
        {
            // Arrange
            this._photoOrganisationRepository.GetAllBasic().Returns(new List<PhotoOrganisationEntity> { new PhotoOrganisationEntity
                {
                    Name = "test1",
                },
                new PhotoOrganisationEntity
                {
                    Name = "test2",
                }
            });
            
            // Act
            var lResult = await this.referenceServices.GetOrganisations();

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count);
            Assert.AreEqual("test1", lResult[0].Name);
        }

        [Test]
        public async Task GetSectionTypes_GetsInfoFromDbAndMaps()
        {
            // Arrange
            this._sectionTypeRepository.GetAll().Returns(new List<SectionTypeEntity> { new SectionTypeEntity
                {
                    Name = "test1",
                },
                new SectionTypeEntity
                {
                    Name = "test2",
                }
            });



            // Act
            var lResult = await this.referenceServices.GetSectionTypes();

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count);
            Assert.AreEqual("test1", lResult[0].Name);
        }

        [Test]
        public async Task GetCircuits_GetsInfoFromDbAndMaps()
        {
            // Arrange
            this._circuitRepository.GetAll().Returns(new List<CircuitEntity> { new CircuitEntity
                {
                    Name = "test1",
                },
                new CircuitEntity
                {
                    Name = "test2",
                }
            });



            // Act
            var lResult = await this.referenceServices.GetCircuits();

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count);
            Assert.AreEqual("test1", lResult[0].Name);
        }

        [Test]
        public async Task GetCountries()
        {
            this._referenceRepository.GetCountries().Returns(new List<CountryEntity>() { new CountryEntity(), new CountryEntity() });
            List<CountryDto> lCountries = await this.referenceServices.GetCountries();
            Assert.AreEqual(2, lCountries.Count);
        }

        [Test]
        public async Task CreateCountry()
        {
            this._referenceRepository.Add(Arg.Any<CountryEntity>()).Returns(info =>
            {
                var myEnt = info.Arg<CountryEntity>();
                myEnt.Id = 40;
                return myEnt;
            });

            CreateCountryDto lCreateCountryDto = new CreateCountryDto()
            {
                Name = "England"
            };

            var lNewlyCreatedCountryDto = await this.referenceServices.CreateCountry(lCreateCountryDto);

            Assert.AreEqual("England", lNewlyCreatedCountryDto.Name);
            Assert.AreEqual(40, lNewlyCreatedCountryDto.Id);
        }


        [Test]
        public async Task DeleteCountry()
        {
            this._referenceRepository.GetById(Arg.Any<int>()).Returns(new CountryEntity()
            {
                Id = 123,
                Name = "England",
            });

            await this.referenceServices.DeleteCountry(123);

            await this._referenceRepository.Received(1).Delete(Arg.Is<CountryEntity>(dto => dto.Id == 123));
        }

        [Test]
        public async Task GetCountryById()
        {
            this._referenceRepository.GetById(Arg.Any<int>()).Returns(new CountryEntity()
            {
                Id = 123,
                Name = "England",
            });

            var lCountryModel = await this.referenceServices.GetCountryById(123);
            Assert.AreEqual(123, lCountryModel.Id);

            await this._referenceRepository.Received(1).GetById(Arg.Is<int>(123));
        }


        [Test]
        public async Task UpdateCountryTest()
        {
            this._referenceRepository.GetById(Arg.Any<int>()).Returns(new CountryEntity()
            {
                Id = 123,
                Name = "England",
            });

            var lCountryModel = await this.referenceServices.GetCountryById(123);

            lCountryModel.Name = "Scotland";

            await this.referenceServices.UpdateCountry(lCountryModel);

            await this._referenceRepository.Received(1).Update(Arg.Is<CountryEntity>(dto => dto.Name == "Scotland"));
        }
    }
}
