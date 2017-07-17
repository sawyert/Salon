using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using SalonServices;
using Salon.Models.Submission;
using Salon.Mappings;
using SalonServices.Dto.Submission;
using SalonServices.Dto;

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

        #region Pages
        public IActionResult Index(int pPersonId)
        {
            var lVm = new SubmissionListViewModel
            {
                PersonId = pPersonId
            };
            return View(lVm);
        }

        [HttpGet]
        public IActionResult AddSubmission(int pPersonId)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SubmissionResults(int pSubmissionId)
        {
            var lResultsDto = await this._submissionService.GetSubmissionResults(pSubmissionId);
            var lVm = Mapping.Mapper.Map<SubmissionResultsViewModel>(lResultsDto);
            return View(lVm);
        }

        [HttpPost]
        public async Task<IActionResult> SubmissionResults([FromForm]SubmissionResultsViewModel pResultsVm)
        {
            if (!ModelState.IsValid)
            {
                return View(pResultsVm);
            }
            await this._submissionService.UpdateSubmissionResults(Mapping.Mapper.Map<SubmissionResultsDto>(pResultsVm));
            pResultsVm.ResultsUpdated = true;
            return View(pResultsVm);
        }
        #endregion

        #region Reference Data
        [HttpGet]
        public async Task<List<CircuitViewModel>> GetCircuits()
        {
            var lCircuitDtos = await this._referenceServices.GetCircuits();
            return lCircuitDtos.Select(dto => Mapping.Mapper.Map<CircuitViewModel>(dto)).ToList();
        }

        [HttpPost]
        public async Task<CreateCircuitViewModel> AddCircuit(CreateCircuitViewModel pCircuitViewModel)
        {
            if (!ModelState.IsValid)
            {
                pCircuitViewModel.Errors = ModelState.Values.SelectMany(val => val.Errors).Select(err => err.ErrorMessage).ToList();
                return pCircuitViewModel;
            }
            var lDto = Mapping.Mapper.Map<CreateCircuitDto>(pCircuitViewModel);
            var lReturnedDto = await this._referenceServices.CreateCircuit(lDto);
            return Mapping.Mapper.Map<CreateCircuitViewModel>(lReturnedDto);
        }

        [HttpGet]
        public async Task<List<SectionTypeViewModel>> GetSectionTypes()
        {
            var lSectionTypeDtos = await this._referenceServices.GetSectionTypes();
            return lSectionTypeDtos.Select(dto => Mapping.Mapper.Map<SectionTypeViewModel>(dto)).ToList();
        }
        
        [HttpGet]
        public async Task<List<OrganisationViewModel>> GetOrganisations()
        {
            var lOrganisationDtos = await this._referenceServices.GetOrganisations();
            return lOrganisationDtos.Select(dto => Mapping.Mapper.Map<OrganisationViewModel>(dto)).ToList();
        }

        [HttpGet]
        public async Task<List<CountryViewModel>> GetCountries()
        {
            var lCountryDtos = await this._referenceServices.GetCountries();
            return lCountryDtos.Select(dto => Mapping.Mapper.Map<CountryViewModel>(dto)).ToList();
        }
        #endregion

        #region Salon and Salon Year
        [HttpGet]
        public async Task<List<FullSalonInformationViewModel>> GetSalons()
        {
            var lDtos = await this._salonYearService.GetFullSalonInformation();
            return lDtos.Select(dto => Mapping.Mapper.Map<FullSalonInformationViewModel>(dto)).ToList();
        }

        [HttpPost]
        public async Task<CreateSalonViewModel> AddSalon(CreateSalonViewModel pAddSalonVm)
        {
            if (!ModelState.IsValid)
            {
                pAddSalonVm.Errors = ModelState.Values.SelectMany(val => val.Errors).Select(err => err.ErrorMessage).ToList();
                return pAddSalonVm;
            }
            var lDto = Mapping.Mapper.Map<CreateSalonDto>(pAddSalonVm);
            var lReturnedDto = await this._salonYearService.CreateSalon(lDto);
            return Mapping.Mapper.Map<CreateSalonViewModel>(lReturnedDto);
        }

        [HttpGet]
        public async Task<List<SalonYearInformationViewModel>> GetSalonYears(int pYear)
        {
            var lDtos = await this._salonYearService.GetSalonYears(pYear);
            return lDtos.Select(dto => Mapping.Mapper.Map<SalonYearInformationViewModel>(dto)).ToList();
        }

        [HttpPost]
        public async Task<CreateSalonYearViewModel> AddSalonYear(CreateSalonYearViewModel pAddSalonYearVm)
        {
            if (!ModelState.IsValid)
            {
                pAddSalonYearVm.Errors = ModelState.Values.SelectMany(val => val.Errors).Select(err => err.ErrorMessage).ToList();
                return pAddSalonYearVm;
            }
            var lDto = Mapping.Mapper.Map<CreateSalonYearDto>(pAddSalonYearVm);
            var lReturnedDto = await this._salonYearService.CreateSalonYear(lDto);
            return Mapping.Mapper.Map<CreateSalonYearViewModel>(lReturnedDto);
        }
        #endregion

        [HttpPost]
        public async Task<SubmissionSaveViewModel> AddSubmission(SubmissionSaveViewModel pSaveViewModel)
        {
            if (!ModelState.IsValid)
            {
                pSaveViewModel.Errors = ModelState.Values.SelectMany(val => val.Errors).Select(err => err.ErrorMessage).ToList();
                return pSaveViewModel;
            }
            var lDto = Mapping.Mapper.Map<SubmissionSaveDto>(pSaveViewModel);
            var lReturnedSubmissionDto = await this._submissionService.CreateSubmission(lDto);
            return Mapping.Mapper.Map<SubmissionSaveViewModel>(lReturnedSubmissionDto);            ;
        }
    }
}
