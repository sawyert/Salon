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

        public IActionResult Error()
        {
            return View();
        }
    }
}
