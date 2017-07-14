using NSubstitute;
using NUnit.Framework;
using SalonServices.Dto.Submission;
using SalonServices.Mappings;
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

        [SetUp]
        public void Setup()
        {

            this.submissionService = new SubmissionService();

            Mapping.CreateConfiguration();
        }


        [Test]
        public async Task CreateSubmission_ReturnsInfoAndCallsDb()
        {
            // Act
            var lResult = await this.submissionService.CreateSubmission(new SubmissionSaveDto());

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
