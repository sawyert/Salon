using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using SalonServices;

namespace Salon.Controllers
{
    public class CountryController : Controller
    {
        private readonly IReferenceServices _referenceServices;
        public CountryController(IReferenceServices pReferenceServices)
        {
            this._referenceServices = pReferenceServices;
        }

        public async Task<IActionResult> Index()
        {
            var lDtos = await _referenceServices.ListCountries();
            return View(new List<CountryModel>());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new CreateCountryModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateCountryModel pCreateModel)
        {
            if(!ModelState.IsValid)
            {
                pCreateModel.Errors = ModelState.Values.SelectMany(val => val.Errors).Select(err => err.ErrorMessage).ToList();
                return View(pCreateModel);
            }

            // map to Dto

            //var lCreatedDto = await _referenceServices.AddCountry(pCreateDto);
            // map to create country model
            pCreateModel.Id = 50;
            return View(pCreateModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(new CreateCountryModel());
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CreateCountryModel pCreateModel)
        {
            if (!ModelState.IsValid)
            {
                pCreateModel.Errors = ModelState.Values.SelectMany(val => val.Errors).Select(err => err.ErrorMessage).ToList();
                return View(pCreateModel);
            }

            // map to Dto

            //var lCreatedDto = await _referenceServices.AddCountry(pCreateDto);
            // map to create country model
            pCreateModel.Id = 50;
            return View(pCreateModel);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return View(new CreateCountryModel());
        }
    }
}
