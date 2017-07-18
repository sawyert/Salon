using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
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
    public class SectionTypeControllerTest
    {
        private SectionTypeController sectionTypeController;
        private IReferenceServices ReferenceServices;

        [SetUp]
        public void Setup()
        {
            this.ReferenceServices = Substitute.For<IReferenceServices>();
            this.sectionTypeController = new SectionTypeController(this.ReferenceServices);
            this.sectionTypeController.Url = Substitute.For<IUrlHelper>();
            this.sectionTypeController.Url.Action(Arg.Any<UrlActionContext>()).Returns(t => {
                var firstArg = t.ArgAt<UrlActionContext>(0);
                return firstArg.Action + firstArg.Values.ToString();
                });
            Mapping.CreateConfiguration();
        }



        [Test]
        public async Task TestGetSectionTypes()
        {
            this.ReferenceServices.GetSectionTypes().Returns(new List<SectionTypeDto> {
                new SectionTypeDto(){
                    Name = "England"
                },
                new SectionTypeDto(){
                    Name = "Wales"
                },
                new SectionTypeDto(){
                    Name = "Scotland"
                },
            });

            IActionResult lResult = await this.sectionTypeController.Index();
            ViewResult lViewResult = lResult as ViewResult;
            var lModel = lViewResult.Model as SectionTypeIndexViewModel;
            Assert.IsNull(lModel.SuccessMessage);
            Assert.IsNull(lModel.FailureMessage);
            Assert.AreEqual(3, lModel.SectionTypes.Count);
        }

        [Test]
        public async Task TestSectionTypeMessages()
        {
            // Arrange
            this.ReferenceServices.GetSectionTypes().Returns(new List<SectionTypeDto> { });
            
            // Act
            IActionResult lResult = await this.sectionTypeController.Index(successMessage: "TestSuccess", failureMessage: "TestFailure");

            // Assert
            ViewResult lViewResult = lResult as ViewResult;
            var lModel = lViewResult.Model as SectionTypeIndexViewModel;
            Assert.AreEqual("TestSuccess", lModel.SuccessMessage);
            Assert.AreEqual("TestFailure", lModel.FailureMessage);
        }

        [Test]
        public async Task TestGetEdit()
        {
            this.ReferenceServices.GetSectionTypeById(10).Returns(
                new SectionTypeDto(){
                    Id = 10,
                    Name = "England"
                }
            );

            IActionResult lResult = await this.sectionTypeController.Edit(10);
            ViewResult lViewResult = lResult as ViewResult;
            var lSectionTypeViewModel = lViewResult.Model as SectionTypeViewModel;
            Assert.AreEqual(10, lSectionTypeViewModel.Id);
            Assert.AreEqual("England", lSectionTypeViewModel.Name);
        }

        [Test]
        public async Task TestEdit()
        {
            this.ReferenceServices.UpdateSectionType(Arg.Any<SectionTypeDto>()).Returns(Task.CompletedTask);

            SectionTypeViewModel lSectionTypeViewModel = new SectionTypeViewModel()
            {
                Name = "England"
            };
            IActionResult lResult = await this.sectionTypeController.Edit(lSectionTypeViewModel);
            RedirectToActionResult lViewResult = lResult as RedirectToActionResult;
            Assert.AreEqual("SectionType successfully updated", lViewResult.RouteValues["successMessage"]);

            await this.ReferenceServices.Received(1).UpdateSectionType(Arg.Is<SectionTypeDto>(dto => dto.Name == "England"));
        }

        [Test]
        public async Task TestEditFailure()
        {
            CreateSectionTypeViewModel lCreateSectionTypeViewModel = new CreateSectionTypeViewModel()
            {
                Name = "England"
            };
            this.sectionTypeController.ModelState.AddModelError("aa", "error");
            IActionResult lResult = await this.sectionTypeController.Add(lCreateSectionTypeViewModel);
            ViewResult lViewResult = lResult as ViewResult;
            var lViewModel = lViewResult.Model as CreateSectionTypeViewModel;
            Assert.AreEqual("England", lViewModel.Name);

            await this.ReferenceServices.Received(0).CreateSectionType(Arg.Any<CreateSectionTypeDto>());
        }

        [Test]
        public async Task TestAdd()
        {
            this.ReferenceServices.CreateSectionType(Arg.Any<CreateSectionTypeDto>()).Returns(new SectionTypeDto { Id = 50 });

            CreateSectionTypeViewModel lCreateSectionTypeViewModel = new CreateSectionTypeViewModel()
            {
                Name = "England"
            };
            IActionResult lResult = await this.sectionTypeController.Add(lCreateSectionTypeViewModel);
            RedirectToActionResult lViewResult = lResult as RedirectToActionResult;
            Assert.AreEqual("SectionType successfully created", lViewResult.RouteValues["successMessage"]);

            await this.ReferenceServices.Received(1).CreateSectionType(Arg.Is<CreateSectionTypeDto>(dto => dto.Name == "England"));
        }

        [Test]
        public async Task TestAddFailure()
        {
            CreateSectionTypeViewModel lCreateSectionTypeViewModel = new CreateSectionTypeViewModel()
            {
                Name = "England"
            };
            this.sectionTypeController.ModelState.AddModelError("aa", "error");
            IActionResult lResult = await this.sectionTypeController.Add(lCreateSectionTypeViewModel);
            ViewResult lViewResult = lResult as ViewResult;
            var lViewModel = lViewResult.Model as CreateSectionTypeViewModel;
            Assert.AreEqual("England", lViewModel.Name);

            await this.ReferenceServices.Received(0).CreateSectionType(Arg.Any<CreateSectionTypeDto>());
        }


        [Test]
        public async Task TestDeleteSectionTypes()
        {
            // Arrange
            this.ReferenceServices.DeleteSectionType(Arg.Any<int>()).Returns(true);

            // Act
            IActionResult lResult = await this.sectionTypeController.Delete(5);

            // Assert
            ContentResult lContentResult = lResult as ContentResult;
            Assert.IsTrue(lContentResult.Content.Contains("successfully deleted"));
            await this.ReferenceServices.Received(1).DeleteSectionType(5);
            this.sectionTypeController.Url.Received(1).Action(Arg.Is<UrlActionContext>(t => t.Action == "Index"));
        }
    }
}
