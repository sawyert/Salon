using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using SalonServices;

namespace Salon.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReferenceServices _referenceServices;
        public HomeController(IReferenceServices pReferenceServices)
        {
            this._referenceServices = pReferenceServices;
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
