using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using SalonServices.Dto;
using SalonServices.Dto.Submission;
using SalonServices.Entities;
using SalonServices.Mappings;
using SalonServices.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Tests.Unit.ServiceTests
{
    [TestFixture]
    public class ReferenceService_Circuits_Tests : BaseReferenceServiceTests
    {   
        [Test]
        public async Task GetCircuits_GetsInfoFromDbAndMaps()
        {
            // Arrange
            this._circuitRepository.GetAll().Returns(new List<CircuitEntity> { new CircuitEntity
                {
                    Name = "test1",
                },
                new CircuitEntity
                {
                    Name = "test2",
                }
            });



            // Act
            var lResult = await this.referenceServices.GetCircuits();

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count);
            Assert.AreEqual("test1", lResult[0].Name);
        }

        [Test]
        public async Task CreateCircuit()
        {
            this._circuitRepository.Add(Arg.Any<CircuitEntity>()).Returns(info =>
            {
                var myEnt = info.Arg<CircuitEntity>();
                myEnt.Id = 40;
                return myEnt;
            });

            CreateCircuitDto lCreateCircuit = new CreateCircuitDto()
            {
                Name = "England"
            };

            var lNewlyCreatedCircuitDto = await this.referenceServices.CreateCircuit(lCreateCircuit);

            Assert.AreEqual("England", lNewlyCreatedCircuitDto.Name);
            Assert.AreEqual(40, lNewlyCreatedCircuitDto.Id);
        }
    }
}
