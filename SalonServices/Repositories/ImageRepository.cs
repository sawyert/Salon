using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalonServices.Dto;
using SalonServices.Entities;
using SalonServices.Repositories.Interfaces;

namespace SalonServices.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly ISalonDbContext dbContext;

        public ImageRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public ImageEntity GetById(int pImageId)
        {
            var lReturn = this.dbContext.Images.Find(pImageId);
            return lReturn;
        }

        public async Task<List<ImageEntity>> GetSuccessfulImagesForPerson(int pPersonId)
        {
            List<ImageEntity> lAcceptedImages = await this.dbContext.Images.Where(img => img.PersonId == pPersonId && img.Entries.Any(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value == true)).Include(itm => itm.Entries)
                                                          .OrderBy(x => x.Name)
                                                          .ToListAsync();
            return lAcceptedImages;
        }

		public async Task<List<CompetitionEntryEntity>> GetAwardedImagesForPerson(int pPersonId)
		{
            List<CompetitionEntryEntity> lSuccessfulEntries = await this.dbContext.CompetitionEntries.Where(entry => entry.Image.PersonId == pPersonId && entry.IsAccepted == true && entry.IsAwarded == true)
																		.Include(x => x.Section).ThenInclude(x => x.SalonYear).ThenInclude(x => x.Salon).ThenInclude(x => x.Country)
																		.Include(x => x.Section).ThenInclude(x => x.SalonYear).ThenInclude(x => x.Accreditations)
																		.Include(x => x.Section).ThenInclude(x => x.SectionType)
																		.Include(x => x.Image)
																		.OrderBy(x => x.Image.Name)
																		.ToListAsync();
			return lSuccessfulEntries;
		}

        public async Task<List<CompetitionEntryEntity>> GetImagesForSubmissionList(int pPersonId, PhotoOrganisationEntity pPhotoOrganisationSubmittingTo)
        {
            List<CompetitionEntryEntity> lSuccessfulEntries = await this.dbContext.CompetitionEntries.Where(entry => entry.Image.PersonId == pPersonId && entry.IsAccepted == true && entry.Section.SalonYear.Accreditations.Any(accr => accr.PhotoOrganisationId == pPhotoOrganisationSubmittingTo.Id))
                                                                        .Include(x=>x.Section).ThenInclude(x=>x.SalonYear).ThenInclude(x=>x.Salon).ThenInclude(x=>x.Country)
                                                                        .Include(x => x.Section).ThenInclude(x => x.SalonYear).ThenInclude(x => x.Accreditations)
                                                                        .Include(x=>x.Section).ThenInclude(x=>x.SectionType)
                                                                        .Include(x=>x.Image)
                                                                        .OrderBy(x=>x.Image.Name)
                                                                        .ToListAsync();
            return lSuccessfulEntries;
        }
    }
}
