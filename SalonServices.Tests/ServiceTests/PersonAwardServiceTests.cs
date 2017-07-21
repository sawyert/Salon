using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using SalonServices.Dto;
using SalonServices.Entities;
using SalonServices.Mappings;
using SalonServices.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Tests.Unit.ServiceTests
{
    public class PersonAwardServiceTests
    {
        private IPersonRepository _personRepository;
        private IPhotoOrganisationRepository _photoOrganisationRepository;
        private PersonAwardService awardService;
        private ISectionTypeRepository _sectionTypeRepository;

        [SetUp]
        public void Setup()
        {
            _personRepository = Substitute.For<IPersonRepository>();
            _photoOrganisationRepository = Substitute.For<IPhotoOrganisationRepository>();
            _sectionTypeRepository = Substitute.For<ISectionTypeRepository>();

            this.awardService = new PersonAwardService(_personRepository, _photoOrganisationRepository, _sectionTypeRepository);

            Mapping.CreateConfiguration();
        }

        [Test]
        public async Task GetAllPersons_MapsFromDbEntity()
        {
            // Arrange
            this._personRepository.GetAll().Returns(new List<PersonEntity> {
                new PersonEntity
                {
                    Name = "test"
                },
                new PersonEntity
                {
                    Name = "test"
                }
            });

            // Act
            var result = await this.awardService.GetAllPersons();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
        }

        private PersonEntity GetAwardedPrintPersonEntity()
        {
            return new PersonEntity
            {
                Name = "fred",
                Submissions = new List<SubmissionEntity>
                {
                    new SubmissionEntity
                    {
                        IsJudged = true,

                        Entries = new List<CompetitionEntryEntity>
                        {
                            new CompetitionEntryEntity
                            {
                                IsAccepted = true,
                                IsAwarded = true,
                                Score = 50,
                                Section = new SectionEntity
                                {
                                     SectionType = new SectionTypeEntity
                                     {
                                         IsPrint = true
                                     },
                                     SalonYear = new SalonYearEntity
                                    {
                                        Name = "salon ye",
                                        Accreditations = new List<AccreditationEntity>
                                        {
                                            new AccreditationEntity
                                            {
                                                 PhotoOrganisationId = 1,
                                            },
                                        },
                                        Salon = new SalonEntity
                                        {
                                            Id = 5,
                                            CountryId = 500
                                        }
                                    },
                                },
                                ImageId = 30
                            }
                        }
                    }
                }
            };
        }

        [Test]
        public async Task GetAwardLevelsForPerson_GetsAwardsBasedOnEntries()
        {
            // Arrange
            var lExpected = new PersonAwardTableDto
            {
                PersonName = "fred",
                Organisations = new List<PersonAwardTableOrgDto>
                 {
                     new PersonAwardTableOrgDto
                     {
                         OrginisationName = "org 1",
                         Awards = new List<PersonAwardTableRowDto>
                         {
                             new PersonAwardTableRowDto
                             {
                                AwardName = "award 1",
                                AcceptancesMissing = 1,
                                AwardsMissing = 2,
                                CountriesMissing = 3,
                                DistinctImagesMissing = 4,
                                PrintsMissing = 5,
                                SalonsMissing = 6,
                                AcceptancesRequired = 2,
                                AwardsRequired = 3,
                                CountriesRequired  = 4,
                                DistinctImagesRequired  = 5,
                                PrintsRequired  = 6,
                                SalonsRequired  = 7,
                             },
                             new PersonAwardTableRowDto
                             {
                                 AwardName = "award 2",
                                 AcceptancesRequired = 1,
                             }
                         }
                     },
                     new PersonAwardTableOrgDto
                     {
                         OrginisationName = "org 2"
                     }
                 }
            };

            this._photoOrganisationRepository.GetAllWithAwards().Returns(new List<PhotoOrganisationEntity>
            {
                new PhotoOrganisationEntity
                {
                    Id = 1,
                    Name = "org 1",
                    AwardLevels = new List<AwardLevelEntity>
                    {
                        new AwardLevelEntity
                        {
                            Name = "award 1",
                            MinimumAcceptances = 2,
                            MinimumAwards = 3,
                            MinimumCountries = 4,
                            MinimumDistinctImages = 5,
                            MinimumPrints = 6,
                            MinimumSalons = 7,
                        },
                        new AwardLevelEntity
                        {
                            Name = "award 2",
                            MinimumAcceptances = 1
                        }
                    }
                },
                new PhotoOrganisationEntity
                {
                    Id = 2,
                    Name = "org 2",
                    AwardLevels = new List<AwardLevelEntity>()
                }
            });

            this._personRepository.GetWithSubmissionsSalonsAccreditationSections(5).Returns(GetAwardedPrintPersonEntity());


            // Act
            var lResult = await this.awardService.GetAwardLevelsForPerson(5);

            // Assert
            lExpected.ShouldBeEquivalentTo(lResult);
        }

        [Test]
        public async Task GetAwardLevelsForPerson_NonDistinctImagesSalonsCountriesDontCount()
        {
            // Arrange
            var lExpected = new PersonAwardTableDto
            {
                PersonName = "fred",
                Organisations = new List<PersonAwardTableOrgDto>
                 {
                     new PersonAwardTableOrgDto
                     {
                         OrginisationName = "org 1",
                         Awards = new List<PersonAwardTableRowDto>
                         {
                             new PersonAwardTableRowDto
                             {
                                AwardName = "award 1",
                                AcceptancesMissing = 0,
                                AwardsMissing = 0,
                                CountriesMissing = 1,
                                DistinctImagesMissing = 1,
                                PrintsMissing = 0,
                                SalonsMissing = 1,
                                AcceptancesRequired = 0,
                                AwardsRequired = 0,
                                CountriesRequired  = 2,
                                DistinctImagesRequired  = 2,
                                PrintsRequired  = 0,
                                SalonsRequired  = 2,
                             }
                         }
                     }
                 }
            };

            this._photoOrganisationRepository.GetAllWithAwards().Returns(new List<PhotoOrganisationEntity>
            {
                new PhotoOrganisationEntity
                {
                    Id = 1,
                    Name = "org 1",
                    AwardLevels = new List<AwardLevelEntity>
                    {
                        new AwardLevelEntity
                        {
                            Name = "award 1",
                            MinimumAcceptances = 0,
                            MinimumAwards = 0,
                            MinimumCountries = 2,
                            MinimumDistinctImages = 2,
                            MinimumPrints = 0,
                            MinimumSalons = 2,
                        }
                    }
                }
            });

            var lPerson = GetAwardedPrintPersonEntity();
            // 2 submissions with identical image, salon, and country
            lPerson.Submissions.Add(lPerson.Submissions[0]);
            this._personRepository.GetWithSubmissionsSalonsAccreditationSections(5).Returns(lPerson);


            // Act
            var lResult = await this.awardService.GetAwardLevelsForPerson(5);

            // Assert
            lExpected.ShouldBeEquivalentTo(lResult);
        }

        [Test]
        public async Task GetAwardLevelsForPerson_DifferentOrgDoesntCount()
        {
            // Arrange
            var lExpected = new PersonAwardTableDto
            {
                PersonName = "fred",
                Organisations = new List<PersonAwardTableOrgDto>
                 {
                     new PersonAwardTableOrgDto
                     {
                         OrginisationName = "org 1",
                         Awards = new List<PersonAwardTableRowDto>
                         {
                             new PersonAwardTableRowDto
                             {
                                AwardName = "award 1",
                                AcceptancesMissing = 1,
                                AwardsMissing = 1,
                                CountriesMissing = 1,
                                DistinctImagesMissing = 1,
                                PrintsMissing = 1,
                                SalonsMissing = 1,
                                AcceptancesRequired = 1,
                                AwardsRequired = 1,
                                CountriesRequired  = 1,
                                DistinctImagesRequired  = 1,
                                PrintsRequired  = 1,
                                SalonsRequired  = 1,
                             }
                         }
                     }
                 }
            };

            this._photoOrganisationRepository.GetAllWithAwards().Returns(new List<PhotoOrganisationEntity>
            {
                new PhotoOrganisationEntity
                {
                    Id = 2,
                    Name = "org 1",
                    AwardLevels = new List<AwardLevelEntity>
                    {
                        new AwardLevelEntity
                        {
                            Name = "award 1",
                            MinimumAcceptances = 1,
                            MinimumAwards = 1,
                            MinimumCountries = 1,
                            MinimumDistinctImages = 1,
                            MinimumPrints = 1,
                            MinimumSalons = 1,
                        }
                    }
                }
            });

            var lPerson = GetAwardedPrintPersonEntity();
            this._personRepository.GetWithSubmissionsSalonsAccreditationSections(5).Returns(lPerson);


            // Act
            var lResult = await this.awardService.GetAwardLevelsForPerson(5);

            // Assert
            lExpected.ShouldBeEquivalentTo(lResult);
        }

        [Test]
        public async Task GetAwardLevelsForPerson_NonAcceptedDoesntCountForCountriesImagesPrintsSalons()
        {
            // Arrange
            var lExpected = new PersonAwardTableDto
            {
                PersonName = "fred",
                Organisations = new List<PersonAwardTableOrgDto>
                 {
                     new PersonAwardTableOrgDto
                     {
                         OrginisationName = "org 1",
                         Awards = new List<PersonAwardTableRowDto>
                         {
                             new PersonAwardTableRowDto
                             {
                                AwardName = "award 1",
                                AcceptancesMissing = 1,
                                // Not a possible scenario where an entry is awarded but not accepted. However, helpful for testing to know that it is not something else that is ruling all of the items out (such as different org)
                                AwardsMissing = 0,
                                CountriesMissing = 1,
                                DistinctImagesMissing = 1,
                                PrintsMissing = 1,
                                SalonsMissing = 1,
                                AcceptancesRequired = 1,
                                AwardsRequired = 1,
                                CountriesRequired  = 1,
                                DistinctImagesRequired  = 1,
                                PrintsRequired  = 1,
                                SalonsRequired  = 1,
                             }
                         }
                     }
                 }
            };

            this._photoOrganisationRepository.GetAllWithAwards().Returns(new List<PhotoOrganisationEntity>
            {
                new PhotoOrganisationEntity
                {
                    Id = 1,
                    Name = "org 1",
                    AwardLevels = new List<AwardLevelEntity>
                    {
                        new AwardLevelEntity
                        {
                            Name = "award 1",
                            MinimumAcceptances = 1,
                            MinimumAwards = 1,
                            MinimumCountries = 1,
                            MinimumDistinctImages = 1,
                            MinimumPrints =1,
                            MinimumSalons = 1,
                        }
                    }
                }
            });

            var lPerson = GetAwardedPrintPersonEntity();
            lPerson.Submissions[0].Entries[0].IsAccepted = false;
            lPerson.Submissions[0].Entries[0].IsAwarded = true;
            this._personRepository.GetWithSubmissionsSalonsAccreditationSections(5).Returns(lPerson);


            // Act
            var lResult = await this.awardService.GetAwardLevelsForPerson(5);

            // Assert
            lExpected.ShouldBeEquivalentTo(lResult);
        }
    }
}
