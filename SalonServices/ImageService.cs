using Microsoft.Extensions.Options;
using SalonServices.Dto;
using SalonServices.Dto.Submission;
using System.IO;
using SalonServices.Entities;
using SalonServices.Repositories.Interfaces;
using SalonServices.Repositories;
using System.Linq;

namespace SalonServices
{
    public class ImageService : IImageService
    {
        private readonly FileSettings _fileSettings;
        private readonly IImageRepository _imageRepository;
        private readonly ISubmissionRepository _submissionRepository;

        public ImageService(IOptions<FileSettings> pFileSettings, IImageRepository pImageRepository, ISubmissionRepository pSubmissionRepository)
        {
            _fileSettings = pFileSettings.Value;
            this._imageRepository = pImageRepository;
            this._submissionRepository = pSubmissionRepository;
        }

        public string SaveImage(ImageSaveDetails pImageDetails)
        {
            var lFullPath = $"{_fileSettings.SaveLocation}/{pImageDetails.FileName}";
            File.WriteAllBytes(lFullPath, pImageDetails.ImageContent);
            return lFullPath;
        }

        public ImageDto GetById(int pImageId)
        {
            ImageEntity lImageEntity = this._imageRepository.GetById(pImageId);
            var lReturn = Mappings.Mapping.Mapper.Map<ImageDto>(lImageEntity);

            var lSalonEntriesForImage = this._submissionRepository.GetSalonEntriesForImage(pImageId);
            lReturn.SalonEntries = lSalonEntriesForImage.Select(ent => new ImageSalonEntryDto() {
                JudgeDate = ent.Section.SalonYear.JudgeDate,
		        SalonName = ent.Section.SalonYear.Salon.Name,
		        SectionName = ent.Section.SectionType.Name,
                IsAwarded = ent.IsAwarded.HasValue && ent.IsAwarded.Value == true,
                AwardDetails = ent.AwardDetails,
                IsAccepted =  ent.IsAccepted.HasValue && ent.IsAccepted.Value == true,
		        Score = ent.Score,
            }).ToList();
            return lReturn;
        }
	}
}
