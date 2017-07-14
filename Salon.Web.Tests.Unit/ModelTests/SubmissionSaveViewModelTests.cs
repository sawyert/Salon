using NUnit.Framework;
using Salon.Models.Submission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Salon.Web.Tests.Unit.ModelTests
{
    [TestFixture]
    public class SubmissionSaveViewModelTests
    {
        [Test]
        [TestCase(2, null, ExpectedResult = true)]
        [TestCase(null, 3, ExpectedResult = true)]
        [TestCase(4, 5, ExpectedResult = true)]
        [TestCase(null, null, ExpectedResult = false)]
        public bool Validate_NoSalonIdOrCircuitIsNotValid(int? pSalonYearId, int? pCircuitId)
        {
            // Arrange
            var lModel = new SubmissionSaveViewModel
            {
                SalonYearId = pSalonYearId,
                CircuitId = pCircuitId
            };

            // Act
            var lResult = lModel.Validate(new System.ComponentModel.DataAnnotations.ValidationContext(lModel));

            // Assert
            // If not any, then it is valid
            return !lResult.Any();
        }
    }
}
