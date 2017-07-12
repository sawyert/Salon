using System;
using NUnit.Framework;
using NSubstitute;
using SalonServices.Repositories;
using SalonServices.Dto;
using System.Collections.Generic;
using SalonServices.Entities;
using SalonServices.Mappings;
using System.Threading.Tasks;

namespace SalonServices.Tests
{
    [TestFixture]
    public class CountryTests
    {
        private ICountryRepository referenceRespository;
        private IReferenceServices referenceServices;

        [SetUp]
        public void Setup()
        {
            this.referenceRespository = Substitute.For<ICountryRepository>();
            this.referenceServices = new ReferenceServices(this.referenceRespository);

            Mapping.CreateConfiguration();
        }

        [Test]
        public async Task ListCountries()
        {
            this.referenceRespository.ListCountries().Returns(new List<CountryEntity>() { new CountryEntity(), new CountryEntity() });
            List<CountryDto> lCountries = await this.referenceServices.ListCountries();
            Assert.AreEqual(2, lCountries.Count);
        }

        [Test]
        public async Task CreateCountry()
        {
            this.referenceRespository.Add(Arg.Any<CountryEntity>()).Returns(info =>
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
            this.referenceRespository.GetById(Arg.Any<int>()).Returns(new CountryEntity() {
                Id = 123,
                Name = "England",
            });
            
            await this.referenceServices.DeleteCountry(123);

            await this.referenceRespository.Received(1).Delete(Arg.Is<CountryEntity>(dto => dto.Id == 123));
        }

        [Test]
        public async Task GetCountryById()
        {
            this.referenceRespository.GetById(Arg.Any<int>()).Returns(new CountryEntity()
            {
                Id = 123,
                Name = "England",
            });

            var lCountryModel = await this.referenceServices.GetCountryById(123);
            Assert.AreEqual(123, lCountryModel.Id);

            await this.referenceRespository.Received(1).GetById(Arg.Is<int>(123));
        }


        [Test]
        public async Task UpdateCountryTest()
        {
            this.referenceRespository.GetById(Arg.Any<int>()).Returns(new CountryEntity()
            {
                Id = 123,
                Name = "England",
            });

            var lCountryModel = await this.referenceServices.GetCountryById(123);

            lCountryModel.Name = "Scotland";

            await this.referenceServices.UpdateCountry(lCountryModel);

            await this.referenceRespository.Received(1).Update(Arg.Is<CountryEntity>(dto => dto.Name == "Scotland"));
        }
        
    }
}
