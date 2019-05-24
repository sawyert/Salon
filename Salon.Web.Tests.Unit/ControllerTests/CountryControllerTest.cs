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
    public class CountryControllerTest
    {
        private CountryController countryController;
        private IReferenceServices ReferenceServices;

        [SetUp]
        public void Setup()
        {
            this.ReferenceServices = Substitute.For<IReferenceServices>();
            this.countryController = new CountryController(this.ReferenceServices);
            Mapping.CreateConfiguration();
        }

        [Test]
        public async Task TestGetCountries()
        {
            this.ReferenceServices.GetCountries().Returns(new List<CountryDto> {
                new CountryDto(){
                    Name = "England"
                },
                new CountryDto(){
                    Name = "Wales"
                },
                new CountryDto(){
                    Name = "Scotland"
                },
            });

            IActionResult lResult = await this.countryController.Index();
            ViewResult lViewResult = lResult as ViewResult;
            var lModel = lViewResult.Model as CountryIndexViewModel;
            Assert.IsNull(lModel.SuccessMessage);
            Assert.IsNull(lModel.FailureMessage);
            Assert.AreEqual(3, lModel.Countries.Count);
        }

        [Test]
        public async Task TestCountryMessages()
        {
            // Arrange
            this.ReferenceServices.GetCountries().Returns(new List<CountryDto> { });
            
            // Act
            IActionResult lResult = await this.countryController.Index(successMessage: "TestSuccess", failureMessage: "TestFailure");

            // Assert
            ViewResult lViewResult = lResult as ViewResult;
            var lModel = lViewResult.Model as CountryIndexViewModel;
            Assert.AreEqual("TestSuccess", lModel.SuccessMessage);
            Assert.AreEqual("TestFailure", lModel.FailureMessage);
        }

        [Test]
        public async Task TestGetEdit()
        {
            this.ReferenceServices.GetCountryById(10).Returns(
                new CountryDto(){
                    Id = 10,
                    Name = "England"
                }
            );

            IActionResult lResult = await this.countryController.Edit(10);
            ViewResult lViewResult = lResult as ViewResult;
            var lCountryViewModel = lViewResult.Model as CountryViewModel;
            Assert.AreEqual(10, lCountryViewModel.Id);
            Assert.AreEqual("England", lCountryViewModel.Name);
        }

        [Test]
        public async Task TestEdit()
        {
            this.ReferenceServices.UpdateCountry(Arg.Any<CountryDto>()).Returns(Task.CompletedTask);

            CountryViewModel lCountryViewModel = new CountryViewModel()
            {
                Name = "England"
            };
            IActionResult lResult = await this.countryController.Edit(lCountryViewModel);
            RedirectToActionResult lViewResult = lResult as RedirectToActionResult;
            Assert.AreEqual("Country successfully updated", lViewResult.RouteValues["successMessage"]);

            await this.ReferenceServices.Received(1).UpdateCountry(Arg.Is<CountryDto>(dto => dto.Name == "England"));
        }

        [Test]
        public async Task TestEditFailure()
        {
            CreateCountryViewModel lCreateCountryViewModel = new CreateCountryViewModel()
            {
                Name = "England"
            };
            this.countryController.ModelState.AddModelError("aa", "error");
            IActionResult lResult = await this.countryController.Add(lCreateCountryViewModel);
            ViewResult lViewResult = lResult as ViewResult;
            var lViewModel = lViewResult.Model as CreateCountryViewModel;
            Assert.AreEqual("England", lViewModel.Name);

            await this.ReferenceServices.Received(0).CreateCountry(Arg.Any<CreateCountryDto>());
        }

        [Test]
        public async Task TestAdd()
        {
            this.ReferenceServices.CreateCountry(Arg.Any<CreateCountryDto>()).Returns(new CountryDto { Id = 50 });

            CreateCountryViewModel lCreateCountryViewModel = new CreateCountryViewModel()
            {
                Name = "England"
            };
            IActionResult lResult = await this.countryController.Add(lCreateCountryViewModel);
            RedirectToActionResult lViewResult = lResult as RedirectToActionResult;
            Assert.AreEqual("Country successfully created", lViewResult.RouteValues["successMessage"]);

            await this.ReferenceServices.Received(1).CreateCountry(Arg.Is<CreateCountryDto>(dto => dto.Name == "England"));
        }

        [Test]
        public async Task TestAddFailure()
        {
            CreateCountryViewModel lCreateCountryViewModel = new CreateCountryViewModel()
            {
                Name = "England"
            };
            this.countryController.ModelState.AddModelError("aa", "error");
            IActionResult lResult = await this.countryController.Add(lCreateCountryViewModel);
            ViewResult lViewResult = lResult as ViewResult;
            var lViewModel = lViewResult.Model as CreateCountryViewModel;
            Assert.AreEqual("England", lViewModel.Name);

            await this.ReferenceServices.Received(0).CreateCountry(Arg.Any<CreateCountryDto>());
        }


        [Test]
        public async Task TestDeleteCountries()
        {
            this.ReferenceServices.DeleteCountry(Arg.Any<int>()).Returns(true);

            IActionResult lResult = await this.countryController.Delete(5);
            RedirectToActionResult lViewResult = lResult as RedirectToActionResult;
            Assert.AreEqual("Country successfully deleted", lViewResult.RouteValues["successMessage"]);

            await this.ReferenceServices.Received(1).DeleteCountry(5);

        }
    }
}
