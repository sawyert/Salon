using Microsoft.AspNetCore.Http;
using NSubstitute;
using NUnit.Framework;
using Salon.Models.Submission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Salon.Web.Tests.Unit.ModelTests
{
    [TestFixture]
    public class SubmissionSaveSectionImagesViewModelTests
    {
        [Test]
        [TestCase(2, null, true, ExpectedResult = true)]
        [TestCase(2, "test", false, ExpectedResult = true)]
        [TestCase(null, "test", true, ExpectedResult = true)]
        [TestCase(0, null, false, ExpectedResult = true)]
        [TestCase(null, "test", false, ExpectedResult = false)]
        [TestCase(null, " ", true, ExpectedResult = false)]
        [TestCase(null, null, true, ExpectedResult = false)]
        [TestCase(null, "", true, ExpectedResult = false)]
        public bool Validate_NoImageIdOrEmptyNewImageIsNotValid(int? pImageId, string pImageName, bool pHasFile)
        {
            // Arrange
            var lModel = new SubmissionSaveSectionImagesViewModel
            {
                ImageId = pImageId,
                ImageName = pImageName,
                ImageThumbnail = pHasFile ? Substitute.For<IFormFile>() : null
            };

            // Act
            var lResult = lModel.Validate(new System.ComponentModel.DataAnnotations.ValidationContext(lModel));

            // Assert
            // If not any, then it is valid
            return !lResult.Any();
        }
    }
}
