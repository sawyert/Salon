using SalonServices.Dto.Submission;
using System;
using System.Collections.Generic;
using System.Text;
using SalonServices.Dto;
using System.Threading.Tasks;

namespace SalonServices
{
    public interface IImageService
    {
        string SaveImage(ImageSaveDetails pImageDetails);
        ImageDto GetById(int pImageId);
        Task<List<ImageDto>> GetSuccessfulImagesForPerson(int pPersonId);
        Task<List<ImageSalonEntryDto>> GetAwardedImagesForPerson(int pPersonId);
        Task<List<ImageSalonEntryDto>> GetSubmissionImages(int pPersonId, string pOrganisationName, DateTime pClosingDateCutoff);
    }
}
