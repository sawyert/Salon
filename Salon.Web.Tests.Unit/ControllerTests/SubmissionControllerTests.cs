using GenFu;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NUnit.Framework;
using Salon.Controllers;
using Salon.Mappings;
using Salon.Models;
using Salon.Models.Submission;
using SalonServices;
using SalonServices.Dto;
using SalonServices.Dto.Submission;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Salon.Web.Tests.Unit
{
    [TestFixture]
    public class SubmissionControllerTests
    {
        private SubmissionController submissionController;
        private IReferenceServices _referenceServices;
        private ISubmissionService _submissionService;
        private ISalonYearService _salonYearService;

        [SetUp]
        public void Setup()
        {
            this._referenceServices = Substitute.For<IReferenceServices>();
            this._submissionService = Substitute.For<ISubmissionService>();
            this._salonYearService = Substitute.For<ISalonYearService>();

            this.submissionController = new SubmissionController(this._referenceServices, this._submissionService, this._salonYearService);
            Mapping.CreateConfiguration();
        }

        [Test]
        public async Task GetSalons_GetsFromServiceAndMaps()
        {
            var lFullSalonDtos = A.ListOf<FullSalonInformationDto>();

            this._salonYearService.GetFullSalonInformation().Returns(lFullSalonDtos);

            List<FullSalonInformationViewModel> lResult = await this.submissionController.GetSalons();
           
            Assert.AreEqual(lFullSalonDtos.Count, lResult.Count);
            Assert.AreEqual(lFullSalonDtos[0].SalonName, lResult[0].SalonName);
        }

        [Test]
        public async Task GetSalonYears_GetsFromServiceAndMaps()
        {
            var lSalonYearDtos = A.ListOf<SalonYearInformationDto>();

            this._salonYearService.GetSalonYears(2017).Returns(lSalonYearDtos);

            List<SalonYearInformationViewModel> lResult = await this.submissionController.GetSalonYears(2017);

            Assert.AreEqual(lSalonYearDtos.Count, lResult.Count);
            Assert.AreEqual(lSalonYearDtos[0].Name, lResult[0].Name);
        }

        [Test]
        public async Task GetCountries_GetsFromServiceAndMaps()
        {
            var lCountryDtos = A.ListOf<CountryDto>();

            this._referenceServices.GetCountries().Returns(lCountryDtos);

            List<CountryViewModel> lResult = await this.submissionController.GetCountries();

            Assert.AreEqual(lCountryDtos.Count, lResult.Count);
            Assert.AreEqual(lCountryDtos[0].Name, lResult[0].Name);
        }

        [Test]
        public async Task GetOrganisations_GetsFromServiceAndMaps()
        {
            var lOrgDtos = A.ListOf<OrganisationDto>();

            this._referenceServices.GetOrganisations().Returns(lOrgDtos);

            List<OrganisationViewModel> lResult = await this.submissionController.GetOrganisations();

            Assert.AreEqual(lOrgDtos.Count, lResult.Count);
            Assert.AreEqual(lOrgDtos[0].Name, lResult[0].Name);
        }

        [Test]
        public async Task GetSectionTypes_GetsFromServiceAndMaps()
        {
            var lSectionTypeDtos = A.ListOf<SectionTypeDto>();

            this._referenceServices.GetSectionTypes().Returns(lSectionTypeDtos);

            List<SectionTypeViewModel> lResult = await this.submissionController.GetSectionTypes();

            Assert.AreEqual(lSectionTypeDtos.Count, lResult.Count);
            Assert.AreEqual(lSectionTypeDtos[0].Name, lResult[0].Name);
        }

        [Test]
        public async Task GetCircuits_GetsFromServiceAndMaps()
        {
            var lCircuitDtos = A.ListOf<CircuitDto>();

            this._referenceServices.GetCircuits().Returns(lCircuitDtos);

            List<CircuitViewModel> lResult = await this.submissionController.GetCircuits();

            Assert.AreEqual(lCircuitDtos.Count, lResult.Count);
            Assert.AreEqual(lCircuitDtos[0].Name, lResult[0].Name);
        }

        [Test]
        public async Task AddCircuit()
        {
            // Arrange
            this._referenceServices.CreateCircuit(Arg.Any<CreateCircuitDto>()).Returns(new CreateCircuitDto { Id = 50 });

            CreateCircuitViewModel lCreateCircuitViewModel = new CreateCircuitViewModel()
            {
                Name = "England"
            };

            // Act
            var lResult = await this.submissionController.AddCircuit(lCreateCircuitViewModel);

            // Assert
            Assert.AreEqual(50, lResult.Id);
            await this._referenceServices.Received(1).CreateCircuit(Arg.Is<CreateCircuitDto>(dto => dto.Name == "England"));
        }

        [Test]
        public async Task AddCircuit_Error()
        {
            // Arrange
            CreateCircuitViewModel lCreateCircuitViewModel = new CreateCircuitViewModel()
            {
                Name = "England"
            };

            this.submissionController.ModelState.AddModelError("aa", "error");
            var lResult = await this.submissionController.AddCircuit(lCreateCircuitViewModel);
           
            // Assert
            Assert.AreEqual("England", lResult.Name);
            Assert.IsNull(lResult.Id);
            await this._referenceServices.Received(0).CreateCircuit(Arg.Any<CreateCircuitDto>());
        }

        [Test]
        public async Task AddSalon()
        {
            // Arrange
            this._salonYearService.CreateSalon(Arg.Any<CreateSalonDto>()).Returns(new CreateSalonDto { SalonId = 50 });

            CreateSalonViewModel lCreateSalonVm = new CreateSalonViewModel()
            {
                SalonName = "England"
            };

            // Act
            var lResult = await this.submissionController.AddSalon(lCreateSalonVm);

            // Assert
            Assert.AreEqual(50, lResult.SalonId);
            await this._salonYearService.Received(1).CreateSalon(Arg.Is<CreateSalonDto>(dto => dto.SalonName == "England"));
        }

        [Test]
        public async Task AddSalon_Error()
        {
            // Arrange
            CreateSalonViewModel lCreateSalonVm = new CreateSalonViewModel()
            {
                SalonName = "England"
            };

            this.submissionController.ModelState.AddModelError("aa", "error");
            var lResult = await this.submissionController.AddSalon(lCreateSalonVm);

            // Assert
            Assert.AreEqual("England", lResult.SalonName);
            Assert.IsNull(lResult.SalonId);
            await this._salonYearService.Received(0).CreateSalon(Arg.Any<CreateSalonDto>());
        }

        [Test]
        public async Task AddSalonYear()
        {
            // Arrange
            this._salonYearService.CreateSalonYear(Arg.Any<CreateSalonYearDto>()).Returns(new CreateSalonYearDto { Id = 50 });

            CreateSalonYearViewModel lCreateSalonYearVm = new CreateSalonYearViewModel()
            {
                Name = "England"
            };

            // Act
            var lResult = await this.submissionController.AddSalonYear(lCreateSalonYearVm);

            // Assert
            Assert.AreEqual(50, lResult.Id);
            await this._salonYearService.Received(1).CreateSalonYear(Arg.Is<CreateSalonYearDto>(dto => dto.Name == "England"));
        }

        [Test]
        public async Task AddSalonYear_Error()
        {
            // Arrange
            CreateSalonYearViewModel lCreateSalonYearVm = new CreateSalonYearViewModel()
            {
                Name = "England"
            };

            this.submissionController.ModelState.AddModelError("aa", "error");
            var lResult = await this.submissionController.AddSalonYear(lCreateSalonYearVm);

            // Assert
            Assert.AreEqual("England", lResult.Name);
            Assert.IsNull(lResult.Id);
            await this._salonYearService.Received(0).CreateSalonYear(Arg.Any<CreateSalonYearDto>());
        }

        [Test]
        public async Task AddSubmission()
        {
            // Arrange
            this._submissionService.CreateSubmission(Arg.Any<SubmissionSaveDto>()).Returns(new SubmissionSaveDto { SubmissionCreated = true});

            SubmissionSaveViewModel lSubmissionSaveVm = new SubmissionSaveViewModel()
            {
                  Cost = (decimal)40.13
            };

            // Act
            var lResult = await this.submissionController.AddSubmission(lSubmissionSaveVm);

            // Assert
            Assert.IsTrue(lResult.SubmissionCreated);
            await this._submissionService.Received(1).CreateSubmission(Arg.Is<SubmissionSaveDto>(dto => dto.Cost == (decimal)40.13));
        }

        [Test]
        public async Task AddSubmission_Error()
        {
            // Arrange
            SubmissionSaveViewModel lSubmissionSaveVm = new SubmissionSaveViewModel()
            {
                Cost = (decimal)40.13
            };

            this.submissionController.ModelState.AddModelError("aa", "error");
            var lResult = await this.submissionController.AddSubmission(lSubmissionSaveVm);

            // Assert
            Assert.AreEqual((decimal)40.13, lResult.Cost);
            Assert.IsFalse(lResult.SubmissionCreated);
            await this._submissionService.Received(0).CreateSubmission(Arg.Any<SubmissionSaveDto>());
        }

        [Test]
        public async Task SubmissionResults_GetsFromServiceAndMaps()
        {
            // Arrange
            var lDto = A.New<SubmissionResultsDto>();
            lDto.Entries = A.ListOf<SubmissionResultsEntryDto>();
            
            this._submissionService.GetSubmissionResults(50).Returns(lDto);

            // Act
            var lResult = await this.submissionController.SubmissionResults(50);

            // Assert
            ViewResult lViewResult = lResult as ViewResult;
            var lModel = lViewResult.Model as SubmissionResultsViewModel;
            Assert.IsNotNull(lModel);
            Assert.IsTrue(lModel.Entries.Count > 0);
            await this._submissionService.Received(1).GetSubmissionResults(50);
        }

        [Test]
        public async Task PostSubmissionResults_SendsToService()
        {
            // Arrange
            this._submissionService.UpdateSubmissionResults(Arg.Any<SubmissionResultsDto>()).Returns(Task.CompletedTask);
            A.Configure<SubmissionResultsViewModel>()
                   .Fill(p => p.ResultsUpdated, () => false)
                   ;

            var lVm = A.New<SubmissionResultsViewModel>();
            lVm.Entries = A.ListOf<SubmissionResultsEntryViewModel>();

            // Act
            var lResult = await this.submissionController.SubmissionResults(lVm);

            // Assert
            ViewResult lViewResult = lResult as ViewResult;
            var lModel = lViewResult.Model as SubmissionResultsViewModel;
            Assert.IsNotNull(lModel);
            Assert.IsTrue(lModel.ResultsUpdated);
            await this._submissionService.Received(1).UpdateSubmissionResults(Arg.Is<SubmissionResultsDto>(t => t.SubmissionId == lVm.SubmissionId && t.Entries.ToList().Count() == lVm.Entries.Count));
        }

        [Test]
        public async Task PostSubmissionResults_Error()
        {
            // Arrange
            A.Configure<SubmissionResultsViewModel>()
                   .Fill(p => p.ResultsUpdated, () => false)
                   ;

            var lVm = A.New<SubmissionResultsViewModel>();
            lVm.Entries = A.ListOf<SubmissionResultsEntryViewModel>();

            this.submissionController.ModelState.AddModelError("aa", "error");

            // Act
            var lResult = await this.submissionController.SubmissionResults(lVm);

            // Assert
            ViewResult lViewResult = lResult as ViewResult;
            var lModel = lViewResult.Model as SubmissionResultsViewModel;
            Assert.IsNotNull(lModel);
            Assert.IsFalse(lModel.ResultsUpdated);
            await this._submissionService.Received(0).UpdateSubmissionResults(Arg.Any<SubmissionResultsDto>());
        }
    }
}
