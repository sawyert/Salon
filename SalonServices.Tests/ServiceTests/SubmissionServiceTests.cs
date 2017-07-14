using NSubstitute;
using NUnit.Framework;
using SalonServices.Dto.Submission;
using SalonServices.Mappings;
using SalonServices.Repositories;
using System;
using System.Collections.Generic;
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

        [SetUp]
        public void Setup()
        {
            this._sectionRepository = Substitute.For<ISectionRepository>();
            this._submissionRepository = Substitute.For<ISubmissionRepository>();

            this.submissionService = new SubmissionService(this._sectionRepository, this._submissionRepository);

            Mapping.CreateConfiguration();
        }


        [Test]
        public async Task CreateSubmission_CreatesWithSalonYear()
        {
            // Arrange
            this._sectionRepository.GetSectionsBySalonYearSectionTypeIds(40, Arg.Is<List<int>>(t => t.Count == 2)).Returns(new List<Entities.SectionEntity> { new Entities.SectionEntity { SectionTypeId = 5 } });

            // Act
            var lResult = await this.submissionService.CreateSubmission(new SubmissionSaveDto() { SalonYearId = 40 });

            // Assert
            Assert.IsNotNull(lResult);
        }

        [Test]
        public async Task CreateSubmission_CreatesWithCircuitId()
        {
            // Arrange
            this._sectionRepository.GetSectionsBySalonYearSectionTypeIds(40, Arg.Is<List<int>>(t => t.Count == 2)).Returns(new List<Entities.SectionEntity> { new Entities.SectionEntity { SectionTypeId = 5 } });

            // Act
            var lResult = await this.submissionService.CreateSubmission(new SubmissionSaveDto() { CircuitId = 50 });

            // Assert
            Assert.IsNotNull(lResult);
        }

        [Test]
        public async Task GetSubmissionResults_ReturnsInfoAndCallsDb()
        {
            // Act
            var lResult = await this.submissionService.GetSubmissionResults(40);

            // Assert
            Assert.IsNotNull(lResult);
        }


        [Test]
        public async Task UpdateSubmissionResults_ReturnsInfoAndCallsDb()
        {
            // Act
            await this.submissionService.UpdateSubmissionResults(new SubmissionResultsDto ());

            // Assert
            Assert.IsTrue(false);
        }
    }
}
