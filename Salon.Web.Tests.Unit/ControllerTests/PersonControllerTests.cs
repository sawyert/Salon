using GenFu;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NUnit.Framework;
using Salon.Controllers;
using Salon.Mappings;
using Salon.Models;
using SalonServices;
using SalonServices.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Salon.Web.Tests.Unit
{
    [TestFixture]
    public class PersonControllerTests
    {
        private PersonController personController;
        private IPersonAwardService personAwardService;

        [SetUp]
        public void Setup()
        {
            this.personAwardService = Substitute.For<IPersonAwardService>();
            this.personController = new PersonController(this.personAwardService);
            Mapping.CreateConfiguration();
        }

        [Test]
        public async Task TestListCountries()
        {
            this.personAwardService.GetAllPersons().Returns(new List<BasicPersonDto> {
                new BasicPersonDto(){
                    Name = "England"
                },
                new BasicPersonDto(){
                    Name = "Wales"
                },
                new BasicPersonDto(){
                    Name = "Scotland"
                },
            });

            IActionResult lResult = await this.personController.Index();
            ViewResult lViewResult = lResult as ViewResult;
            var lModel = lViewResult.Model as PersonIndexViewModel;
            Assert.AreEqual(3, lModel.People.Count);
        }

        [Test]
        public async Task View_ReturnsMappedItem()
        {
            A.Configure<PersonAwardTableDto>()
            .Fill(p => p.Organisations, () => A.ListOf<PersonAwardTableOrgDto>());
            var lDto =  A.New<PersonAwardTableDto>();
            this.personAwardService.GetAwardLevelsForPerson(10).Returns(
                lDto
            );

            IActionResult lResult = await this.personController.Details(10);
            ViewResult lViewResult = lResult as ViewResult;
            var lCountryViewModel = lViewResult.Model as PersonAwardTableViewModel;
            Assert.AreEqual(lDto.PersonName, lCountryViewModel.PersonName);
            Assert.AreEqual(lDto.Organisations.Count, lCountryViewModel.Organisations.Count);
        }        
    }
}
