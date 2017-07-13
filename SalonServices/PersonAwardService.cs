using System;
using System.Collections.Generic;
using System.Text;
using SalonServices.Dto;
using SalonServices.Repositories;
using System.Threading.Tasks;
using SalonServices.Entities;
using System.Linq;
using SalonServices.Mappings;

namespace SalonServices
{
    public class PersonAwardService : IPersonAwardService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IPhotoOrganisationRepository _photoOrganisationRepository;

        public PersonAwardService(IPersonRepository pPersonRepository, IPhotoOrganisationRepository pPhotoOrganisationRepository)
        {
            this._personRepository = pPersonRepository;
            this._photoOrganisationRepository = pPhotoOrganisationRepository;
        }
        
        public async Task<List<BasicPersonDto>> GetAllPersons()
        {
            var lPersonEntities = await this._personRepository.GetAll();
            return lPersonEntities.Select(per => Mapping.Mapper.Map<BasicPersonDto>(per)).ToList();
        }

        public async Task<PersonAwardTableDto> GetAwardLevelsForPerson(int pPersonId)
        {
            var lPhotoOrganisationsTask = this._photoOrganisationRepository.GetAllWithAwards();
            var lPersonTask = this._personRepository.GetWithSubmissionsSalonsAccreditationSections(pPersonId);

            await Task.WhenAll(lPhotoOrganisationsTask, lPersonTask);
            var lPerson = lPersonTask.Result;
            var lPhotoOrgs = lPhotoOrganisationsTask.Result;

            var lPersonAwardTable = new PersonAwardTableDto
            {
                PersonName = lPerson.Name
            };

            foreach (var lOrg in lPhotoOrgs)
            {
                var lTableOrg = new PersonAwardTableOrgDto
                {
                    OrginisationName = lOrg.Name
                };

                foreach (var lOrgAward in lOrg.AwardLevels)
                {
                    var lPersonAwardRow = new PersonAwardTableRowDto
                    {
                        AwardName = lOrgAward.Name,
                        AcceptancesMissing = GetAcceptances(lPerson.Submissions, lOrgAward.MinimumAcceptances, lOrg.Id),
                        AwardsMissing = GetAwards(lPerson.Submissions, lOrgAward.MinimumAwards, lOrg.Id),
                        CountriesMissing = GetCountries(lPerson.Submissions, lOrgAward.MinimumCountries, lOrg.Id),
                        DistinctImagesMissing = GetDistinctImages(lPerson.Submissions, lOrgAward.MinimumDistinctImages, lOrg.Id),
                        PrintsMissing = GetPrints(lPerson.Submissions, lOrgAward.MinimumPrints, lOrg.Id),
                        SalonsMissing = GetSalons(lPerson.Submissions, lOrgAward.MinimumSalons, lOrg.Id),    
                    };
                    lTableOrg.Awards.Add(lPersonAwardRow);
                }

                lPersonAwardTable.Organisations.Add(lTableOrg);
            }

            return lPersonAwardTable;
        }

        private bool OrganisationMatches(SectionEntity sectionEntity, int orgId)
        {
            return sectionEntity.SalonYear.Accreditations.Any(acc => acc.PhotoOrganisationId == orgId);
        }

        private int GetPrints(List<SubmissionEntity> submissions, int minimumRequired, int orgId)
        {
            var acceptedEntries = submissions.Sum(sub => sub.Entries.Count(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value && ent.Section.SectionType.IsPrint && OrganisationMatches(ent.Section, orgId)));

            if (acceptedEntries > minimumRequired)
            {
                return 0;
            }

            return minimumRequired - acceptedEntries;
        }
        private int GetDistinctImages(List<SubmissionEntity> submissions, int minimumRequired, int orgId)
        {
            var acceptedEntries = submissions.SelectMany(sub => sub.Entries.Where(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value && OrganisationMatches(ent.Section, orgId)).Select(ent => ent.ImageId)).Distinct().Count();

            if (acceptedEntries > minimumRequired)
            {
                return 0;
            }

            return minimumRequired - acceptedEntries;
        }
        private int GetSalons(List<SubmissionEntity> submissions, int minimumRequired, int orgId)
        {
            var acceptedEntries = submissions.SelectMany(sub => sub.Entries.Where(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value && OrganisationMatches(ent.Section, orgId)).Select(ent => ent.Section.SalonYear.SalonId)).Distinct().Count();

            if (acceptedEntries > minimumRequired)
            {
                return 0;
            }

            return minimumRequired - acceptedEntries;
        }

        private int GetCountries(List<SubmissionEntity> submissions, int minimumRequired, int orgId)
        {
            var acceptedEntries = submissions.SelectMany(sub => sub.Entries.Where(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value && OrganisationMatches(ent.Section, orgId)).Select(ent => ent.Section.SalonYear.Salon.CountryId)).Distinct().Count();

            if (acceptedEntries > minimumRequired)
            {
                return 0;
            }

            return minimumRequired - acceptedEntries;
        }

        private int GetAwards(List<SubmissionEntity> submissions, int minimumRequired, int orgId)
        {
            var acceptedEntries = submissions.Sum(sub => sub.Entries.Count(ent => ent.IsAwarded.HasValue && ent.IsAwarded.Value && OrganisationMatches(ent.Section, orgId)));

            if (acceptedEntries > minimumRequired)
            {
                return 0;
            }

            return minimumRequired - acceptedEntries;
        }

        private int GetAcceptances(List<SubmissionEntity> submissions, int minimumRequired, int orgId)
        {
            var acceptedEntries = submissions.Sum(sub => sub.Entries.Count(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value && OrganisationMatches(ent.Section, orgId)));

            if (acceptedEntries > minimumRequired)
            {
                return 0;
            }

            return minimumRequired - acceptedEntries;
        }
    }
}
