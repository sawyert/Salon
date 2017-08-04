using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using SalonServices;
using Salon.Mappings;
using SalonServices.Dto;

namespace Salon.Controllers
{
    public class CountryController : Controller
    {
        private readonly IReferenceServices _referenceServices;
        public CountryController(IReferenceServices pReferenceServices)
        {
            this._referenceServices = pReferenceServices;
        }

        public async Task<IActionResult> SuccessfulCountries(int pPersonId)
        {
            var lDtos = await this._referenceServices.GetSuccessfulCountries(pPersonId);
            var lCountries = lDtos.Select(itm => Mapping.Mapper.Map<CountryViewModel>(itm)).ToList();
            int row = 1;
            foreach (var lCountry in lCountries)
            {
                lCountry.Number = row;
                row++;
            }

			var lModel = new CountryIndexViewModel()
			{
				Countries = lCountries,
			};
			return View(lModel);
        }

        public async Task<IActionResult> Index(string successMessage = null, string failureMessage = null)
        {
            var lDtos = await this._referenceServices.GetCountries();

            var lModel = new CountryIndexViewModel()
            {
                SuccessMessage = successMessage,
                FailureMessage = failureMessage,
                Countries = lDtos.Select(itm => Mapping.Mapper.Map<CountryViewModel>(itm)).ToList(),
            };
            return View(lModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new CreateCountryViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateCountryViewModel pCreateModel)
        {
            if(!this.ModelState.IsValid)
            {
                pCreateModel.Errors = this.ModelState.Values.SelectMany(val => val.Errors).Select(err => err.ErrorMessage).ToList();
                return View(pCreateModel);
            }

            // map to Dto
            var lDtoToCreate = Mapping.Mapper.Map<CreateCountryDto>(pCreateModel);
            await this._referenceServices.CreateCountry(lDtoToCreate);

            return RedirectToAction("Index", new { successMessage = "Country successfully created" });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            CountryDto lCountryDto = await this._referenceServices.GetCountryById(id);
            var lViewModelToEdit = Mapping.Mapper.Map<CountryViewModel>(lCountryDto);
            //this._referenceServices.
            return View(lViewModelToEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CountryViewModel pViewModelToUpdate)
        {
            if (!ModelState.IsValid)
            {
                return View(pViewModelToUpdate);
            }

            // map to Dto
            CountryDto lCountryDto = Mapping.Mapper.Map<CountryDto>(pViewModelToUpdate);

            await this._referenceServices.UpdateCountry(lCountryDto);

            return RedirectToAction("Index", new { successMessage = "Country successfully updated" });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await this._referenceServices.DeleteCountry(id);
            return RedirectToAction("Index", new { successMessage = "Country successfully deleted" });
        }
    }
}
