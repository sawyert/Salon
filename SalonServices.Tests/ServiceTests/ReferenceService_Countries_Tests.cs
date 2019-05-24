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
    public class ReferenceService_Countries_Tests : BaseReferenceServiceTests
    {        
        [Test]
        public async Task GetCountries()
        {
            this._countryRepository.GetCountries().Returns(new List<CountryEntity>() { new CountryEntity(), new CountryEntity() });
            List<CountryDto> lCountries = await this.referenceServices.GetCountries();
            Assert.AreEqual(2, lCountries.Count);
        }

        [Test]
        public async Task CreateCountry()
        {
            this._countryRepository.Add(Arg.Any<CountryEntity>()).Returns(info =>
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
            this._countryRepository.GetById(Arg.Any<int>()).Returns(new CountryEntity()
            {
                Id = 123,
                Name = "England",
            });

            await this.referenceServices.DeleteCountry(123);

            await this._countryRepository.Received(1).Delete(Arg.Is<CountryEntity>(dto => dto.Id == 123));
        }

        [Test]
        public async Task GetCountryById()
        {
            this._countryRepository.GetById(Arg.Any<int>()).Returns(new CountryEntity()
            {
                Id = 123,
                Name = "England",
            });

            var lCountryModel = await this.referenceServices.GetCountryById(123);
            Assert.AreEqual(123, lCountryModel.Id);

            await this._countryRepository.Received(1).GetById(Arg.Is<int>(123));
        }


        [Test]
        public async Task UpdateCountryTest()
        {
            this._countryRepository.GetById(Arg.Any<int>()).Returns(new CountryEntity()
            {
                Id = 123,
                Name = "England",
            });

            var lCountryModel = await this.referenceServices.GetCountryById(123);

            lCountryModel.Name = "Scotland";

            await this.referenceServices.UpdateCountry(lCountryModel);

            await this._countryRepository.Received(1).Update(Arg.Is<CountryEntity>(dto => dto.Name == "Scotland"));
        }
    }
}
