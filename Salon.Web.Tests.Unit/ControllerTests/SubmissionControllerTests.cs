using GenFu;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NUnit.Framework;
using Salon.Controllers;
using Salon.Mappings;
using Salon.Models;
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

            this._salonYearService.GetSalonYears().Returns(lSalonYearDtos);

            List<SalonYearInformationViewModel> lResult = await this.submissionController.GetSalonYears();

            Assert.AreEqual(lSalonYearDtos.Count, lResult.Count);
            Assert.AreEqual(lSalonYearDtos[0].Name, lResult[0].Name);
        }
    }
}
