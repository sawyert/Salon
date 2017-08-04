using System;
using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using SalonServices;
using SalonServices.Dto;

namespace Salon.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageServices;
		public ImageController(IImageService pImageServices)
		{
			this._imageServices = pImageServices;
		}

		public IActionResult SingleImage(int pImageId)
		{
            var lSingleImage = this._imageServices.GetById(pImageId);

            ImageViewModel lSingleImageViewModel = Mappings.Mapping.Mapper.Map<ImageViewModel>(lSingleImage);

			return View(lSingleImageViewModel);
		}
    }
}
