using NSubstitute;
using NUnit.Framework;
using SalonServices.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalonServices.Tests.Unit.ServiceTests
{
    [TestFixture]
    public class ReferenceService_Orgs_Tests : BaseReferenceServiceTests
    {      
        [Test]
        public async Task GetOrgs_GetsInfoFromDbAndMaps()
        {
            // Arrange
            this._photoOrganisationRepository.GetAllBasic().Returns(new List<PhotoOrganisationEntity> { new PhotoOrganisationEntity
                {
                    Name = "test1",
                },
                new PhotoOrganisationEntity
                {
                    Name = "test2",
                }
            });
            
            // Act
            var lResult = await this.referenceServices.GetOrganisations();

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count);
            Assert.AreEqual("test1", lResult[0].Name);
        }      
    }
}
