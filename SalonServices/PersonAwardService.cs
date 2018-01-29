using System;
using System.Collections.Generic;
using System.Text;
using SalonServices.Dto;
using SalonServices.Repositories;
using System.Threading.Tasks;
using SalonServices.Entities;
using System.Linq;
using SalonServices.Mappings;
using System.Collections;

namespace SalonServices
{
    public class PersonAwardService : IPersonAwardService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IPhotoOrganisationRepository _photoOrganisationRepository;
        private readonly ISectionTypeRepository _sectionTypeRepository;

        public PersonAwardService(IPersonRepository pPersonRepository, IPhotoOrganisationRepository pPhotoOrganisationRepository, ISectionTypeRepository pSectionTypeRepository)
        {
            this._personRepository = pPersonRepository;
            this._photoOrganisationRepository = pPhotoOrganisationRepository;
            this._sectionTypeRepository = pSectionTypeRepository;
        }
        
        public async Task<List<BasicPersonDto>> GetAllPersons()
        {
            var lPersonEntities = await this._personRepository.GetAll();
            List<BasicPersonDto> lReturn = lPersonEntities.Select(per => Mapping.Mapper.Map<BasicPersonDto>(per)).ToList();

            foreach (BasicPersonDto lEachPerson in lReturn)
            {
                lEachPerson.CostPerAcceptance = await this._personRepository.GetCostPerAcceptance(lEachPerson.Id);
                lEachPerson.TotalCost = await this._personRepository.GetTotalCost(lEachPerson.Id);
                lEachPerson.UnjudgedImageCount = await this._personRepository.UnjudgedImageCount(lEachPerson.Id);
                lEachPerson.UnjudgedSalonCount = await this._personRepository.UnjudgedSalonCount(lEachPerson.Id);
                lEachPerson.AcceptanceRate = await this._personRepository.AcceptanceRate(lEachPerson.Id);
            }

            return lReturn;
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
                if (lOrg.EnableSectionTypes == false)
                {
                    // FIAP style add all acceptances
                    var lTableOrg = new PersonAwardTableOrgDto
                    {
                        OrginisationName = lOrg.Name
                    };

                    foreach (var lOrgAward in lOrg.AwardLevels.OrderBy(l => l.Name))
                    {
                        var lPersonAwardRow = new PersonAwardTableRowDto
                        {
                            AwardName = lOrgAward.Name,
                            AcceptancesMissing = await GetAcceptances(lPerson.Submissions, lOrgAward.MinimumAcceptances, lOrg.Id),
                            AcceptancesRequired = lOrgAward.MinimumAcceptances,
                            AwardsMissing = GetAwards(lPerson.Submissions, lOrgAward.MinimumAwards, lOrg.Id),
                            AwardsRequired = lOrgAward.MinimumAwards,
                            CountriesMissing = GetCountries(lPerson.Submissions, lOrgAward.MinimumCountries, lOrg.Id),
                            CountriesRequired = lOrgAward.MinimumCountries,
                            DistinctImagesMissing = GetDistinctImages(lPerson.Submissions, lOrgAward.MinimumDistinctImages, lOrg.Id),
                            DistinctImagesRequired = lOrgAward.MinimumDistinctImages,
                            PrintsMissing = GetPrints(lPerson.Submissions, lOrgAward.MinimumPrints, lOrg.Id),
                            PrintsRequired = lOrgAward.MinimumPrints,
                            SalonsMissing = GetSalons(lPerson.Submissions, lOrgAward.MinimumSalons, lOrg.Id),
                            SalonsRequired = lOrgAward.MinimumSalons,
                            CostToAchieve = GetCostToAchieve(lPerson.Submissions, lOrgAward.MinimumAcceptances, lOrg.Id),
                        };
                        lTableOrg.Awards.Add(lPersonAwardRow);
                    }
                    lPersonAwardTable.Organisations.Add(lTableOrg);
                }
                else
                {
                    // PSA style, group by section type
                    List<string> lSectionTypeCodes = await this._sectionTypeRepository.FetchSectionTypeCodes();

                    foreach (var lSectionTypeCode in lSectionTypeCodes)
                    {
                        var lTableOrg = new PersonAwardTableOrgDto
                        {
                            OrginisationName = lOrg.Name + " " + lSectionTypeCode
                        };

                        foreach (var lOrgAward in lOrg.AwardLevels.OrderBy(l => l.Name))
                        {
                            var lPersonAwardRow = new PersonAwardTableRowDto
                            {
                                AwardName = lOrgAward.Name,
                                AcceptancesMissing = await GetAcceptances(lPerson.Submissions, lOrgAward.MinimumAcceptances, lOrg.Id, lSectionTypeCode),
                                AcceptancesRequired = lOrgAward.MinimumAcceptances,
                                AwardsMissing = GetAwards(lPerson.Submissions, lOrgAward.MinimumAwards, lOrg.Id),
                                AwardsRequired = lOrgAward.MinimumAwards,
                                CountriesMissing = GetCountries(lPerson.Submissions, lOrgAward.MinimumCountries, lOrg.Id),
                                CountriesRequired = lOrgAward.MinimumCountries,
                                DistinctImagesMissing = GetDistinctImages(lPerson.Submissions, lOrgAward.MinimumDistinctImages, lOrg.Id, lSectionTypeCode),
                                DistinctImagesRequired = lOrgAward.MinimumDistinctImages,
                                PrintsMissing = GetPrints(lPerson.Submissions, lOrgAward.MinimumPrints, lOrg.Id),
                                PrintsRequired = lOrgAward.MinimumPrints,
                                SalonsMissing = GetSalons(lPerson.Submissions, lOrgAward.MinimumSalons, lOrg.Id),
                                SalonsRequired = lOrgAward.MinimumSalons,
                                CostToAchieve = GetCostToAchieve(lPerson.Submissions, lOrgAward.MinimumAcceptances, lOrg.Id, lSectionTypeCode),
                            };
                            lTableOrg.Awards.Add(lPersonAwardRow);
                        }

                        lPersonAwardTable.Organisations.Add(lTableOrg);
                    }
                }

            }

            return lPersonAwardTable;
        }

        private bool OrganisationMatches(SectionEntity sectionEntity, int orgId)
        {
            return sectionEntity.SalonYear.Accreditations.Any(acc => acc.PhotoOrganisationId == orgId);
        }

        private bool SectionTypeMatches(SectionEntity sectionEntity, string pSectionTypeCode)
        {
            if (pSectionTypeCode == null)
            {
                return true;
            }

            return sectionEntity.SectionType.SectionCode == pSectionTypeCode;
        }

        private int GetPrints(List<SubmissionEntity> submissions, int minimumRequired, int orgId)
        {
            var acceptedEntries = submissions.SelectMany(sub => sub.Entries.Where(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value && ent.Section.SectionType.IsPrint && OrganisationMatches(ent.Section, orgId)).Select(ent => ent.ImageId)).Distinct().Count();

            if (acceptedEntries > minimumRequired)
            {
                return 0;
            }

            return minimumRequired - acceptedEntries;
        }
        private int GetDistinctImages(List<SubmissionEntity> submissions, int minimumRequired, int orgId, string pSectionTypeCode = null)
        {
            var acceptedEntries = submissions.SelectMany(sub => sub.Entries.Where(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value && OrganisationMatches(ent.Section, orgId) && SectionTypeMatches(ent.Section, pSectionTypeCode)).Select(ent => ent.ImageId)).Distinct().Count();

            if (acceptedEntries > minimumRequired)
            {
                return 0;
            }

            return minimumRequired - acceptedEntries;
        }
        private int GetSalons(List<SubmissionEntity> submissions, int minimumRequired, int orgId)
        {
            var acceptedSalonEntries = submissions.SelectMany(sub => sub.Entries.Where(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value && OrganisationMatches(ent.Section, orgId) && ent.Section.SalonYear.CircuitId == null).Select(ent => ent.Section.SalonYear.SalonId)).Distinct().Count();
            var acceptedCircuitEntries = submissions.SelectMany(sub => sub.Entries.Where(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value && OrganisationMatches(ent.Section, orgId) && ent.Section.SalonYear.CircuitId != null).Select(ent => ent.Section.SalonYear.CircuitId)).Distinct().Count();
            var totalAcceptances = acceptedCircuitEntries + acceptedSalonEntries;

            if (totalAcceptances > minimumRequired)
            {
                return 0;
            }

            return minimumRequired - totalAcceptances;
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

        private decimal GetCostToAchieve(List<SubmissionEntity> submissions, int minimumRequired, int orgId, string pSectionTypeCode = null)
        {
            int lAcceptancesCounted = 0;
            decimal lCostToDate = 0.0M;
            foreach (var lEachSubmission in submissions)
            {
                if (lEachSubmission.Entries.Any(ent => ent.Section.SalonYear.Accreditations.Any(acc=> acc.PhotoOrganisationId == orgId)))
                {
                    if (pSectionTypeCode == null || lEachSubmission.Entries.Any(ent => ent.Section.SectionType.SectionCode == pSectionTypeCode))
                    {
                        lAcceptancesCounted += lEachSubmission.Entries.Count(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value);
                        lCostToDate += lEachSubmission.EntryCost;
                    }
                }

                if (lAcceptancesCounted > minimumRequired)
                {
                    break;
                }
            }

            return lCostToDate;

        }

        private async Task<int> GetAcceptances(List<SubmissionEntity> submissions, int minimumRequired, int orgId, string pSectionTypeCode = null)
        {
            var lOrganisation = await this._photoOrganisationRepository.GetById(orgId);
            if ("GPU".Equals(lOrganisation.Name))
            {
                // GPU style scoring
                // Accept = 1, Award = 2, Medal = 4
                // Taken from international salons (so no BPE)
                // Doubled scores for GPU Patronised salons
                var lFiap = await this._photoOrganisationRepository.GetByName("FIAP"); // this org has all internationals that I've done

                // count of FIAP acceptances, less GPU acceptances
                var lFiapAccepted = submissions.Sum(sub => sub.Entries.Count(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value && ent.IsAwarded.HasValue && ent.IsAwarded.Value == false && OrganisationMatches(ent.Section, lFiap.Id) && OrganisationMatches(ent.Section, lOrganisation.Id) == false && SectionTypeMatches(ent.Section, pSectionTypeCode)));
                // FIAP awards
                var lFiapAwards = submissions.Sum(sub => sub.Entries.Count(ent => ent.IsAwarded.HasValue && ent.IsAwarded.Value && OrganisationMatches(ent.Section, lFiap.Id) && OrganisationMatches(ent.Section, lOrganisation.Id) == false));

                // GPU acceptances
                var lGpuAccepted = submissions.Sum(sub => sub.Entries.Count(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value && ent.IsAwarded.HasValue && ent.IsAwarded.Value == false && OrganisationMatches(ent.Section, lOrganisation.Id) && SectionTypeMatches(ent.Section, pSectionTypeCode)));
                // GPU Awards
                var lGpuAwards = submissions.Sum(sub => sub.Entries.Count(ent => ent.IsAwarded.HasValue && ent.IsAwarded.Value && OrganisationMatches(ent.Section, lOrganisation.Id)));

                var acceptedEntries = lFiapAccepted + (lGpuAccepted * 2) + (lFiapAwards * 2) + (lGpuAwards * 2 * 2);

                if (acceptedEntries > minimumRequired)
                {
                    return 0;
                }

                return minimumRequired - acceptedEntries;
            }
            else
            {
                // Standard scoring
                var acceptedEntries = submissions.Sum(sub => sub.Entries.Count(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value && OrganisationMatches(ent.Section, orgId) && SectionTypeMatches(ent.Section, pSectionTypeCode)));

                if (acceptedEntries > minimumRequired)
                {
                    return 0;
                }

                return minimumRequired - acceptedEntries;
            }
        }

        public async Task<OrganisationSubmissionReportDto> GetOrganisationSubmissionList(int pPersonId, string pOrganisationName, string pSectionTypeCode=null)
        {
            var lPersonTask = this._personRepository.GetWithSubmissionsSalonsAccreditationSections(pPersonId);
            Task<List<PhotoOrganisationEntity>> lAllPhotoOrgsTask = this._photoOrganisationRepository.GetAllBasic();
            await Task.WhenAll(lPersonTask, lAllPhotoOrgsTask);
            PhotoOrganisationEntity lOrganisation = lAllPhotoOrgsTask.Result.FirstOrDefault(org => org.Name == pOrganisationName);
            var lPerson = lPersonTask.Result;

            var lEntryEntities = lPerson.Submissions.SelectMany(sub => sub.Entries.Where(ent => ent.IsAccepted.HasValue && ent.IsAccepted.Value && OrganisationMatches(ent.Section, lOrganisation.Id) && SectionTypeMatches(ent.Section, pSectionTypeCode))).ToList(); // .OrderBy(x => x.Section.SalonYear.ClosingDate).ThenBy(x => x.Image.Name).ToList();

            List<OrganisationAcceptedEntryReportDto> lAcceptedEntries = new List<OrganisationAcceptedEntryReportDto>();
            foreach (CompetitionEntryEntity lEachEntity in lEntryEntities)
            {
                var lAcceptedEntry = Mapping.Mapper.Map<OrganisationAcceptedEntryReportDto>(lEachEntity);
                foreach (AccreditationEntity lAccreditationEntity in lEachEntity.Section.SalonYear.Accreditations)
                {
                    if (lAccreditationEntity.PhotoOrganisation.Name == pOrganisationName)
                    {
                        lAcceptedEntry.SalonNumber = lAccreditationEntity.SalonNumber;
                    }

                }

                lAcceptedEntries.Add(lAcceptedEntry);
            }

            return new OrganisationSubmissionReportDto() {
                AcceptedEntries = lAcceptedEntries,
            };
        }
    }
}
