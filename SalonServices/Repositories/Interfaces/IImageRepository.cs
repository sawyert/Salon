using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SalonServices.Dto;
using SalonServices.Entities;

namespace SalonServices.Repositories.Interfaces
{
    public interface IImageRepository
    {
        ImageEntity GetById(int pImageId);
        Task<List<ImageEntity>> GetSuccessfulImagesForPerson(int pPersonId);
        Task<List<CompetitionEntryEntity>> GetAwardedImagesForPerson(int pPersonId);
        Task<List<CompetitionEntryEntity>> GetImagesForSubmissionList(int pPersonId, PhotoOrganisationEntity pPhotoOrganisationSubmittingTo, DateTime pClosingDateCutoff);
    }
}
