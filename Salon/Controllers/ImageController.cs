using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<IActionResult> SuccessfulImages(int pPersonId)
        {
            List<ImageDto> lSuccessfulImages = await this._imageServices.GetSuccessfulImagesForPerson(pPersonId);

            List<ImageViewModel> lSuccessfulImagesViewModel = new List<ImageViewModel>();
            foreach (ImageDto lSuccesfulImage in lSuccessfulImages)
            {
                var lImageViewModel = Mappings.Mapping.Mapper.Map<ImageViewModel>(lSuccesfulImage);
                lSuccessfulImagesViewModel.Add(lImageViewModel);
            }

            return View(lSuccessfulImagesViewModel);
        }

		public async Task<IActionResult> AwardedImages(int pPersonId)
		{
			List<ImageSalonEntryDto> lSuccessfulImages = await this._imageServices.GetAwardedImagesForPerson(pPersonId);

			List<ImageSalonViewModel> lSuccessfulImagesViewModel = new List<ImageSalonViewModel>();
			int lAcceptanceNumber = 0;
			int lImageNumber = 0;
			string lImageName = "";
			foreach (ImageSalonEntryDto lSuccesfulImage in lSuccessfulImages)
			{
				var lImageSalonViewModel = Mappings.Mapping.Mapper.Map<ImageSalonViewModel>(lSuccesfulImage);
				if (lImageName != lImageSalonViewModel.ImageTitle)
				{
					lImageNumber++;
				}
				lAcceptanceNumber++;
				lImageName = lImageSalonViewModel.ImageTitle;
				lImageSalonViewModel.ImageNumber = lImageNumber;
				lImageSalonViewModel.AcceptanceNumber = lAcceptanceNumber;
				lSuccessfulImagesViewModel.Add(lImageSalonViewModel);
			}

			return View(lSuccessfulImagesViewModel);
		}

        public async Task<IActionResult> FiapImages(int pPersonId)
        {
            List<ImageSalonEntryDto> lFiapImages = await this._imageServices.GetSubmissionImages(pPersonId, "FIAP", new DateTime(2017,7,1));
            List<ImageSalonViewModel> lFiapImagesViewModel = new List<ImageSalonViewModel>();
            int lAcceptanceNumber = 0;
            int lImageNumber = 0;
            string lImageName = "";
            foreach (ImageSalonEntryDto lFiapImage in lFiapImages)
            {
				var lImageSalonViewModel = Mappings.Mapping.Mapper.Map<ImageSalonViewModel>(lFiapImage);
                if (lImageName != lImageSalonViewModel.ImageTitle)
                {
                    lImageNumber++;
                }
				lAcceptanceNumber++;
                lImageName = lImageSalonViewModel.ImageTitle;
                lImageSalonViewModel.ImageNumber = lImageNumber;
                lImageSalonViewModel.AcceptanceNumber = lAcceptanceNumber;
				lFiapImagesViewModel.Add(lImageSalonViewModel);
            }

            return View(lFiapImagesViewModel);
        }
    }
}
