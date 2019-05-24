using GenFu;
using NUnit.Framework;
using Salon.Models;
using SalonServices.Dto;
using Salon.Mappings;
using Salon.Web.Tests.Helper;
using SalonServices.Dto.Submission;
using Salon.Models.Submission;
using System.Text.RegularExpressions;

namespace Salon.Web.Tests.Unit.MappingTests
{
    [TestFixture]
    public class SalonAndSalonYearMapperTests
    {
        [SetUp]
        public void Setup()
        {
            Mapping.CreateConfiguration();
        }

        [Test]
        public void MapSalonFullInformationDtoToViewModel()
        {
            MappingTestHelpers.MapFromModelAndBack<FullSalonInformationViewModel, FullSalonInformationDto>();
        }

        [Test]
        public void MapSalonYearInformationModelToDtoAndBack()
        {
            A.Configure<SalonYearInformationViewModel>()
                    .Fill(p => p.Accreditations, () => A.ListOf<SalonYearAccreditationViewModel>());

            MappingTestHelpers.MapFromModelAndBack<SalonYearInformationViewModel, SalonYearInformationDto>();
        }

        [Test]
        public void MapCreateSalonDtoToViewModel()
        {
            MappingTestHelpers.MapFromModelAndBack<CreateSalonViewModel, CreateSalonDto>();
        }

        [Test]
        public void MapCreateSalonYearDtoToViewModel()
        {
            MappingTestHelpers.MapFromModelAndBack<CreateSalonYearViewModel, CreateSalonYearDto>();
        }

        [Test]
        public void MapCreateSubmissionDtoToViewModel()
        {
            A.Configure<SubmissionSaveViewModel>()
                    .Fill(p => p.Sections, () => A.ListOf<SubmissionSaveSectionViewModel>());

            A.Configure<SubmissionSaveSectionViewModel>()
                    .Fill(p => p.Images, () => A.ListOf<SubmissionSaveSectionImagesViewModel>());
            MappingTestHelpers.MapFromModelAndBack<SubmissionSaveViewModel, SubmissionSaveDto>();
        }

        [Test]
        public void MapSubmissionResultsDtoToViewModel()
        {
            A.Configure<SubmissionResultsViewModel>()
                    .Fill(p => p.Entries, () => A.ListOf<SubmissionResultsEntryViewModel>());
            
            MappingTestHelpers.MapFromModelAndBack<SubmissionResultsViewModel, SubmissionResultsDto>();
        }

        [Test]
        public void MapSubmissionResultEntrysDtoToViewModel()
        {
            MappingTestHelpers.MapFromModelAndBack<SubmissionResultsEntryViewModel, SubmissionResultsEntryDto>();
        }

        [Test]
        public void MapSubmissionListItemDtoToViewModel()
        {
            MappingTestHelpers.MapFromModelAndBack<SubmissionListItemViewModel, SubmissionListItemDto>();
        }
    }
}
