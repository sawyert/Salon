using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using SalonServices;
using Salon.Models.Submission;
using Salon.Mappings;

namespace Salon.Controllers
{
    public class SubmissionController : Controller
    {
        private readonly IReferenceServices _referenceServices;
        private readonly ISubmissionService _submissionService;
        private readonly ISalonYearService _salonYearService;


        public SubmissionController(IReferenceServices pReferenceServices, ISubmissionService pSubmissionService, ISalonYearService pSalonYearService)
        {
            this._referenceServices = pReferenceServices;
            this._submissionService = pSubmissionService;
            this._salonYearService = pSalonYearService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddSubmission(int pPersonId)
        {
            return View();
        }

        [HttpGet]
        public IActionResult SubmissionResults(int pSubmissionId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmissionResults(SubmissionResultsViewModel pResultsVm)
        {
            return View();
        }

        [HttpGet]
        public async Task<List<CircuitViewModel>> GetCircuits()
        {
            return new List<CircuitViewModel>();
        }

        [HttpPost]
        public async Task<CreateCircuitViewModel> AddCircuit(CreateCircuitViewModel pCircuitViewModel)
        {
            if (!ModelState.IsValid)
            {
                //todo set errors
                return pCircuitViewModel;
            }
            return pCircuitViewModel;
        }

        [HttpGet]
        public async Task<List<SectionViewModel>> GetSections()
        {
            return new List<SectionViewModel>();
        }

        [HttpPost]
        public async Task<bool> AddSection(SectionViewModel pSectionViewModel)
        {
            if (!ModelState.IsValid)
            {
                return false;
            }
            return true;
        }

        [HttpGet]
        public async Task<List<SectionTypeViewModel>> GetSectionTypes()
        {
            return new List<SectionTypeViewModel>();
        }

        [HttpPost]
        public async Task<bool> AddSectionType(SectionTypeViewModel pSectionTypeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return false;
            }
            return true;
        }

        [HttpGet]
        public async Task<List<OrganisationViewModel>> GetOrganisations()
        {
            
            return new List<OrganisationViewModel>();
        }

        [HttpGet]
        public async Task<List<FullSalonInformationViewModel>> GetSalons()
        {
            var lDtos = await this._salonYearService.GetFullSalonInformation();
            return lDtos.Select(dto => Mapping.Mapper.Map<FullSalonInformationViewModel>(dto)).ToList();
        }

        [HttpPost]
        public async Task<CreateSalonViewModel> AddSalon(CreateSalonViewModel pAddSalon)
        {
            if (!ModelState.IsValid)
            {
                pAddSalon.Errors = ModelState.Values.SelectMany(val => val.Errors).Select(err => err.ErrorMessage).ToList();
                return pAddSalon;
            }
            
            return pAddSalon;
        }

        [HttpGet]
        public async Task<List<SalonYearInformationViewModel>> GetSalonYears()
        {
            var lDtos = await this._salonYearService.GetSalonYears();
            return lDtos.Select(dto => Mapping.Mapper.Map<SalonYearInformationViewModel>(dto)).ToList();
        }

        [HttpPost]
        public async Task<CreateSalonYearViewModel> AddSalonYear(CreateSalonYearViewModel pAddSalonYear)
        {
            if (!ModelState.IsValid)
            {
                pAddSalonYear.Errors = ModelState.Values.SelectMany(val => val.Errors).Select(err => err.ErrorMessage).ToList();
                return pAddSalonYear;
            }

            return pAddSalonYear;
        }

        [HttpPost]
        public SubmissionSaveViewModel AddSubmission(SubmissionSaveViewModel pSaveViewModel)
        {
            if (!ModelState.IsValid)
            {
                return pSaveViewModel;
            }
            pSaveViewModel.SubmissionCreated = true;
            return pSaveViewModel;
        }

        [HttpGet]
        public async Task<List<CountryViewModel>> GetCountries()
        {
            var lDtos = await _referenceServices.ListCountries();
            return new List<CountryViewModel>();
        }      

    }
}
