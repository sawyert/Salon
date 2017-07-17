using SalonServices.Dto.Submission;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices
{
    public interface IImageService
    {
        string SaveImage(ImageSaveDetails pImageDetails);
    }
}
