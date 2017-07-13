﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using SalonServices;

namespace Salon.Controllers
{
    public class SubmissionController : Controller
    {
        private readonly IReferenceServices _referenceServices;
        public SubmissionController(IReferenceServices pReferenceServices)
        {
            this._referenceServices = pReferenceServices;
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
        public async Task<bool> AddCircuit(CircuitViewModel pCircuitViewModel)
        {
            if (!ModelState.IsValid)
            {
                return false;
            }
            return true;
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
        public async Task<List<SalonYearAccreditationsViewModel>> GetSalonInformation()
        {
            return new List<SalonYearAccreditationsViewModel>();
        }

        [HttpPost]
        public async Task<SalonYearAccreditationsViewModel> AddSalonInformation(SalonYearAccreditationsViewModel pAddSalon)
        {
            if (!ModelState.IsValid)
            {
                pAddSalon.Errors = ModelState.Values.SelectMany(val => val.Errors).Select(err => err.ErrorMessage).ToList();
                return pAddSalon;
            }
            
            return pAddSalon;
        }

        [HttpPost]
        public bool AddSubmission()
        {
            if (!ModelState.IsValid)
            {
                return false;
            }
            return true;
        }

        [HttpGet]
        public async Task<List<CountryViewModel>> GetCountries()
        {
            var lDtos = await _referenceServices.ListCountries();
            return new List<CountryViewModel>();
        }

        [HttpPost]
        public async Task<CreateCountryViewModel> AddCountry(CreateCountryViewModel pCreateModel)
        {
            if(!ModelState.IsValid)
            {
                pCreateModel.Errors = ModelState.Values.SelectMany(val => val.Errors).Select(err => err.ErrorMessage).ToList();
                return pCreateModel;
            }

            // map to Dto

            // var lCreatedDto = await _referenceServices.AddCountry(pCreateDto);
            // map to create country model
            pCreateModel.Id = 50; //lCreatedDto.Id;
            return pCreateModel;
        }

    }
}
