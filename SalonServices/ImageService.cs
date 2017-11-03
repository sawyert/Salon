using Microsoft.Extensions.Options;
using SalonServices.Dto;
using SalonServices.Dto.Submission;
using System.IO;
using SalonServices.Entities;
using SalonServices.Repositories.Interfaces;
using SalonServices.Repositories;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalonServices
{
    public class ImageService : IImageService
    {
        private readonly FileSettings _fileSettings;
        private readonly IImageRepository _imageRepository;
        private readonly ISubmissionRepository _submissionRepository;
        private readonly IPhotoOrganisationRepository _organisationRepository;

        public ImageService(IOptions<FileSettings> pFileSettings, IImageRepository pImageRepository, ISubmissionRepository pSubmissionRepository, IPhotoOrganisationRepository pOrganisationRepository)
        {
            _fileSettings = pFileSettings.Value;
            this._imageRepository = pImageRepository;
            this._submissionRepository = pSubmissionRepository;
            this._organisationRepository = pOrganisationRepository;
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

        public async Task<List<ImageDto>> GetSuccessfulImagesForPerson(int pPersonId)
        {
            List<ImageEntity> lSuccessfulImages = await this._imageRepository.GetSuccessfulImagesForPerson(pPersonId);

			List<ImageDto> lReturn = new List<ImageDto>();
			foreach (ImageEntity lSuccesfulImage in lSuccessfulImages)
			{
				var lImageDto = Mappings.Mapping.Mapper.Map<ImageDto>(lSuccesfulImage);
				lReturn.Add(lImageDto);
			}

            return lReturn;
        }

		public async Task<List<ImageSalonEntryDto>> GetAwardedImagesForPerson(int pPersonId)
		{
			List<CompetitionEntryEntity> lAwardedImages = await this._imageRepository.GetAwardedImagesForPerson(pPersonId);

			List<ImageSalonEntryDto> lReturn = new List<ImageSalonEntryDto>();
			foreach (CompetitionEntryEntity lAwardedImage in lAwardedImages)
			{
				var lImageDto = Mappings.Mapping.Mapper.Map<ImageSalonEntryDto>(lAwardedImage);
				lReturn.Add(lImageDto);
			}

			return lReturn;
		}

        public async Task<List<ImageSalonEntryDto>> GetSubmissionImages(int pPersonId, string pOrganisationName, DateTime pClosingDateCutoff)
        {
            PhotoOrganisationEntity lOrganisation = await this._organisationRepository.GetByName(pOrganisationName);
            List<CompetitionEntryEntity> lSuccessfulImages = await this._imageRepository.GetImagesForSubmissionList(pPersonId, lOrganisation, pClosingDateCutoff);

            List<ImageSalonEntryDto> lReturn = new List<ImageSalonEntryDto>();
            foreach (CompetitionEntryEntity lEachSuccessfulEntry in lSuccessfulImages)
            {
                var lImageSalonEntryDto = Mappings.Mapping.Mapper.Map<ImageSalonEntryDto>(lEachSuccessfulEntry);
                var lSalonAccreditation = lEachSuccessfulEntry.Section.SalonYear.Accreditations.FirstOrDefault(acc => acc.PhotoOrganisationId == lOrganisation.Id);
                lImageSalonEntryDto.OrganisationAccreditationNumber = lSalonAccreditation.SalonNumber;
				lReturn.Add(lImageSalonEntryDto);
            }

            return lReturn;
        }
    }
}
