using GenFu;
using NUnit.Framework;
using SalonServices.Dto;
using SalonServices.Dto.Submission;
using SalonServices.Entities;
using SalonServices.Mappings;
using SalonServices.Tests.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Tests.Unit.MappingTests
{
    [TestFixture]
    public class SubmissionMapperTests
    {
        [SetUp]
        public void Setup()
        {
            Mapping.CreateConfiguration();
        }

        [Test]
        public void MapSubmissionToEntityAndBack()
        {
            A.Configure<SubmissionSaveDto>()
              .Fill(p => p.SalonYearId, () => 40)
              ;

            MappingTestHelpers.MapFromModelAndBack<SubmissionSaveDto, SubmissionEntity>();
        }


        [Test]
        public void MapSubmissionImageToEntityAndBack()
        {
            A.Configure<SubmissionSaveSectionImagesDto>()
                .Fill(p => p.ImageId, () => 40)
                ;

            MappingTestHelpers.MapFromModelAndBack<SubmissionSaveSectionImagesDto, ImageEntity>(null, conf => conf.Excluding(d => d.Extension));
        }

        [Test]
        public void MapSubmissionResultsEntryToEntityAndBack()
        {
            A.Configure<SubmissionResultsEntryDto>()
                .Fill(p => p.Score, () => 40)
                .Fill(p => p.IsAccepted, () => true)
                .Fill(p => p.IsAwarded, () => true)
                ;

            MappingTestHelpers.MapFromModelAndBack<SubmissionResultsEntryDto, CompetitionEntryEntity>();
        }        
    }
}
