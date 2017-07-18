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
    public class ReferenceService_SectionTypes_Tests : BaseReferenceServiceTests
    {

        [Test]
        public async Task GetSectionTypes_GetsInfoFromDbAndMaps()
        {
            // Arrange
            this._sectionTypeRepository.GetAll().Returns(new List<SectionTypeEntity> { new SectionTypeEntity
                {
                    Name = "test1",
                },
                new SectionTypeEntity
                {
                    Name = "test2",
                }
            });



            // Act
            var lResult = await this.referenceServices.GetSectionTypes();

            // Assert
            Assert.IsNotNull(lResult);
            Assert.AreEqual(2, lResult.Count);
            Assert.AreEqual("test1", lResult[0].Name);
        }

        [Test]
        public async Task CreateSectionType()
        {
            this._sectionTypeRepository.Add(Arg.Any<SectionTypeEntity>()).Returns(info =>
            {
                var myEnt = info.Arg<SectionTypeEntity>();
                myEnt.Id = 40;
                return myEnt;
            });

            CreateSectionTypeDto lCreateSectionTypeDto = new CreateSectionTypeDto()
            {
                Name = "England"
            };

            var lNewlyCreatedSectionTypeDto = await this.referenceServices.CreateSectionType(lCreateSectionTypeDto);

            Assert.AreEqual("England", lNewlyCreatedSectionTypeDto.Name);
            Assert.AreEqual(40, lNewlyCreatedSectionTypeDto.Id);
        }


        [Test]
        public async Task DeleteSectionType()
        {
            this._sectionTypeRepository.GetById(Arg.Any<int>()).Returns(new SectionTypeEntity()
            {
                Id = 123,
                Name = "England",
            });

            await this.referenceServices.DeleteSectionType(123);
            await this._sectionTypeRepository.Received(1).Delete(Arg.Is<SectionTypeEntity>(dto => dto.Id == 123));
        }

        [Test]
        public async Task GetSectionTypeById()
        {
            this._sectionTypeRepository.GetById(Arg.Any<int>()).Returns(new SectionTypeEntity()
            {
                Id = 123,
                Name = "England",
            });

            var lSectionTypeModel = await this.referenceServices.GetSectionTypeById(123);
            Assert.AreEqual(123, lSectionTypeModel.Id);

            await this._sectionTypeRepository.Received(1).GetById(Arg.Is<int>(123));
        }

        [Test]
        public async Task UpdateSectionTypeTest()
        {
            this._sectionTypeRepository.GetById(Arg.Any<int>()).Returns(new SectionTypeEntity()
            {
                Id = 123,
                Name = "England",
            });

            var lSectionTypeModel = await this.referenceServices.GetSectionTypeById(123);

            lSectionTypeModel.Name = "Scotland";

            await this.referenceServices.UpdateSectionType(lSectionTypeModel);

            await this._sectionTypeRepository.Received(1).Update(Arg.Is<SectionTypeEntity>(dto => dto.Name == "Scotland"));
        }
    }
}
