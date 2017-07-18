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
    public class SectionTypeController : Controller
    {
        private readonly IReferenceServices _referenceServices;
        public SectionTypeController(IReferenceServices pReferenceServices)
        {
            this._referenceServices = pReferenceServices;
        }

        public async Task<IActionResult> Index(string successMessage = null, string failureMessage = null)
        {
            var lDtos = await this._referenceServices.GetSectionTypes();

            var lModel = new SectionTypeIndexViewModel()
            {
                SuccessMessage = successMessage,
                FailureMessage = failureMessage,
                SectionTypes = lDtos.Select(itm => Mapping.Mapper.Map<SectionTypeViewModel>(itm)).ToList(),
            };
            return View(lModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new CreateSectionTypeViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateSectionTypeViewModel pCreateModel)
        {
            if(!this.ModelState.IsValid)
            {
                pCreateModel.Errors = this.ModelState.Values.SelectMany(val => val.Errors).Select(err => err.ErrorMessage).ToList();
                return View(pCreateModel);
            }

            // map to Dto
            var lDtoToCreate = Mapping.Mapper.Map<CreateSectionTypeDto>(pCreateModel);
            await this._referenceServices.CreateSectionType(lDtoToCreate);

            return RedirectToAction("Index", new { successMessage = "SectionType successfully created" });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            SectionTypeDto lSectionTypeDto = await this._referenceServices.GetSectionTypeById(id);
            var lViewModelToEdit = Mapping.Mapper.Map<SectionTypeViewModel>(lSectionTypeDto);
            //this._referenceServices.
            return View(lViewModelToEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SectionTypeViewModel pViewModelToUpdate)
        {
            if (!ModelState.IsValid)
            {
                return View(pViewModelToUpdate);
            }

            // map to Dto
            SectionTypeDto lSectionTypeDto = Mapping.Mapper.Map<SectionTypeDto>(pViewModelToUpdate);

            await this._referenceServices.UpdateSectionType(lSectionTypeDto);

            return RedirectToAction("Index", new { successMessage = "SectionType successfully updated" });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await this._referenceServices.DeleteSectionType(id);
            return Content(this.Url.Action("Index", new { successMessage = "SectionType successfully deleted" }));
        }
    }
}
