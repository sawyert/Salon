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
using System;
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
    }
}
