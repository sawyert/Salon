using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using SalonServices;
using Salon.Mappings;
using SalonServices.Dto;
using Salon.Models.Submission;

namespace Salon.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonAwardService _personAwardService;
        public PersonController(IPersonAwardService _personAwardService)
        {
            this._personAwardService = _personAwardService;
        }

        public async Task<IActionResult> Index()
        {
            var lDtos = await this._personAwardService.GetAllPersons();

            var lModel = new PersonIndexViewModel()
            {
                People = lDtos.Select(itm => Mapping.Mapper.Map<BasicPersonViewModel>(itm)).ToList(),
            };
            return View(lModel);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var lAwardLevelDto = await this._personAwardService.GetAwardLevelsForPerson(id);
            return View(Mapping.Mapper.Map<PersonAwardTableViewModel>(lAwardLevelDto));
        }

        [HttpGet]
        public async Task<IActionResult> PsaList(int pPersonId, string pSectionCode)
        {
            var lPsaSubmissionDto = await this._personAwardService.GetOrganisationSubmissionList(pPersonId, "PSA", pSectionCode);
            return View(Mapping.Mapper.Map<PsaSubmissionViewModel>(lPsaSubmissionDto));
        }
    }
}
