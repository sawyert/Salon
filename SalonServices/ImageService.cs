using Microsoft.Extensions.Options;
using SalonServices.Dto;
using SalonServices.Dto.Submission;
using System.IO;

namespace SalonServices
{
    public class ImageService : IImageService
    {
        private readonly FileSettings _fileSettings;

        public ImageService(IOptions<FileSettings> pFileSettings)
        {
            _fileSettings = pFileSettings.Value;
        }

        public string SaveImage(ImageSaveDetails pImageDetails)
        {
            var lFullPath = $"{_fileSettings.SaveLocation}/{pImageDetails.FileName}";
            File.WriteAllBytes(lFullPath, pImageDetails.ImageContent);
            return lFullPath;
        }
    }
}
