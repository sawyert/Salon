using NUnit.Framework;
using SalonServices.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Tests.Unit.DtoTests
{
    [TestFixture]
    public class PersonAwardTableRowDtoTests
    {
        [Test]
        [TestCase(1, 0, 0, 0, 0, 0, ExpectedResult = false)]
        [TestCase(0, 1, 0, 0, 0, 0, ExpectedResult = false)]
        [TestCase(0, 0, 1, 0, 0, 0, ExpectedResult = false)]
        [TestCase(0, 0, 0, 1, 0, 0, ExpectedResult = false)]
        [TestCase(0, 0, 0, 0, 1, 0, ExpectedResult = false)]
        [TestCase(0, 0, 0, 0, 0, 1, ExpectedResult = false)]
        [TestCase(7, 6, 5, 2, 3, 4, ExpectedResult = false)]
        [TestCase(0, 0, 0, 0, 0, 0, ExpectedResult = true)]

        public bool IsAwarded_AnyNot0(int pAcceptancesMissing, int pCountriesMissing, int pAwardsMissing, int pDistinctImagesMissing, int pSalonsMissing, int pPrintsMissing)
        {
            // Arrange
            var lRow = new PersonAwardTableRowDto
            {
                AwardName = "name",
                AcceptancesMissing = pAcceptancesMissing,
                CountriesMissing = pCountriesMissing,
                AwardsMissing = pAwardsMissing,
                DistinctImagesMissing = pDistinctImagesMissing,
                SalonsMissing = pSalonsMissing,
                PrintsMissing = pPrintsMissing
            };

            // Assert
            return lRow.IsAwarded;
        }
    }
}
