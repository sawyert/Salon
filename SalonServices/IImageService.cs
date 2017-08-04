using SalonServices.Dto.Submission;
using System;
using System.Collections.Generic;
using System.Text;
using SalonServices.Dto;

namespace SalonServices
{
    public interface IImageService
    {
        string SaveImage(ImageSaveDetails pImageDetails);
        ImageDto GetById(int pImageId); 
    }
}
