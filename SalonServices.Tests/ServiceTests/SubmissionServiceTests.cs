using Microsoft.EntityFrameworkCore.Storage;
using NSubstitute;
using NUnit.Framework;
using SalonServices.Dto.Submission;
using SalonServices.Entities;
using SalonServices.Mappings;
using SalonServices.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Tests.Unit.ServiceTests
{
    [TestFixture]
    public class SubmissionServiceTests
    {
        private SubmissionService submissionService;
        private ISectionRepository _sectionRepository;
        private ISubmissionRepository _submissionRepository;
        private ISalonYearRepository _salonYearRepository;
        private IImageService _imageService;
        private IDbTransaction _dbTransaction;

        [SetUp]
        public void Setup()
        {
            this._sectionRepository = Substitute.For<ISectionRepository>();
            this._submissionRepository = Substitute.For<ISubmissionRepository>();
            this._salonYearRepository = Substitute.For<ISalonYearRepository>();
            this._imageService = Substitute.For<IImageService>();
            this._dbTransaction = Substitute.For<IDbTransaction>();
            var lDbTransaction = Substitute.For<IDbContextTransaction>();

            this._dbTransaction.BeginTransactionAsync().Returns(lDbTransaction);

            this.submissionService = new SubmissionService(this._sectionRepository, this._submissionRepository, this._salonYearRepository, this._imageService, this._dbTransaction);

            Mapping.CreateConfiguration();
        }


        [Test]
        public async Task CreateSubmission_CreatesWithSalonYear()
        {
            // Arrange
            var lImageLocation = "this locate";
            this._sectionRepository.GetSectionsBySalonYearSectionTypeIds(40, Arg.Is<List<int>>(t => t.Count == 2)).Returns(new List<SectionEntity> { new SectionEntity { SectionTypeId = 5 } });
            this._imageService.SaveImage(Arg.Any<ImageSaveDetails>()).Returns(lImageLocation);
            
            // Act
            var lResult = await this.submissionService.CreateSubmission(new SubmissionSaveDto() { PersonId = 30, SalonYearId = 40,
                Sections = new List<SubmissionSaveSectionDto> {
                    new SubmissionSaveSectionDto {
                        SectionTypeId = 5, Images = new List<SubmissionSaveSectionImagesDto> { new SubmissionSaveSectionImagesDto { ImageId = 1 } }
                    },
                    new SubmissionSaveSectionDto {
                        SectionTypeId = 6, Images = new List<SubmissionSaveSectionImagesDto> { new SubmissionSaveSectionImagesDto { ImageId = 1 },
                                                                                               new SubmissionSaveSectionImagesDto { ImageName = "image name", ImageNotes = "notes" } }
                    }
                } });

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.SubmissionCreated);
            await this._submissionRepository.Received(1).Add(Arg.Is<SubmissionEntity>(t => t.SalonYearId == 40 
                                                    && t.Entries.Count == 3 
                                                    && t.Entries.Count(ent => ent.ImageId == 1) == 2                                                 
                                                    && t.Entries.Count(ent => ent.Section != null && ent.Image != null && ent.Section.SectionTypeId == 6 && ent.Image.Name == "image name" && ent.Image.PersonId == 30 && ent.Image.ThumbnailLocation == lImageLocation) == 1
                                                    ));
        }
        
        [Test]
        public async Task CreateSubmission_CreatesWithCircuitId()
        {
            // Arrange
            this._sectionRepository.GetSectionsBySalonYearSectionTypeIds(Arg.Any<int>(), Arg.Is<List<int>>(t => t.Count == 1)).Returns(new List<SectionEntity> { new SectionEntity { Id = 50 , SectionTypeId = 5 } });
            this._salonYearRepository.GetSalonYearsIdsByCircuitId(50).Returns(new List<int> { 13, 14, 15 });

            // Act
            var lResult = await this.submissionService.CreateSubmission(new SubmissionSaveDto() { CircuitId = 50, Sections = new List<SubmissionSaveSectionDto> { new SubmissionSaveSectionDto { SectionTypeId = 5, Images = new List<SubmissionSaveSectionImagesDto> { new SubmissionSaveSectionImagesDto { ImageId = 1 } } } } });

            // Assert
            Assert.IsNotNull(lResult);
            Assert.IsTrue(lResult.SubmissionCreated);
            await this._submissionRepository.Received(3).Add(Arg.Is<SubmissionEntity>(t => (t.SalonYearId == 13 || t.SalonYearId == 14 || t.SalonYearId == 15) && t.Entries.Any(ent => ent.ImageId == 1 && ent.Section.Id == 50)));
        }

        [Test]
        public async Task GetSubmissionResults_ReturnsInfoAndCallsDb()
        {
            // Arrange
            this._submissionRepository.GetSubmissionResults(40).Returns(new SubmissionResultsDto
            {
                Entries = new List<SubmissionResultsEntryDto>
                {
                    new SubmissionResultsEntryDto
                    {

                    },
                    new SubmissionResultsEntryDto
                    {

                    },
                }
            });

            // Act
            var lResult = await this.submissionService.GetSubmissionResults(40);

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Entries.Count());
        }
        
        [Test]
        public async Task UpdateSubmissionResults_ReturnsInfoAndCallsDb()
        {
            // Arrange
            this._submissionRepository.GetSubmissionWithEntries(40).Returns(new SubmissionEntity
            {
                IsJudged = false,
                Entries = new List<CompetitionEntryEntity>
                {
                    new CompetitionEntryEntity
                    {
                        Id = 50
                    },
                    new CompetitionEntryEntity
                    {
                        Id = 70
                    },
                }
            });
            // Act
            await this.submissionService.UpdateSubmissionResults(new SubmissionResultsDto() {
                SubmissionId = 40,
                Entries = new List<SubmissionResultsEntryDto>
                {
                    new SubmissionResultsEntryDto
                    {
                        Id = 70, 
                        IsAccepted = true,
                        IsAwarded = true,
                        Score = 50
                    },
                    new SubmissionResultsEntryDto
                    {
                        Id = 50,
                        IsAccepted = false,
                        IsAwarded = false,
                        Score = 99
                    }
                } });

            // Assert
            await this._submissionRepository.Received(1).Update(Arg.Is<SubmissionEntity>(sub => sub.IsJudged 
                && sub.Entries.Count == 2
                && sub.Entries.Count(ent => ent.Id == 50 && ent.IsAccepted == false && ent.IsAwarded == false && ent.Score == 99) == 1
                && sub.Entries.Count(ent => ent.Id == 70 && ent.IsAccepted == true && ent.IsAwarded == true && ent.Score == 50) == 1
            ));
        }
    }
}
