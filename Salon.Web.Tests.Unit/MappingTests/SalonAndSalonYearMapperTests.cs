using GenFu;
using NUnit.Framework;
using Salon.Models;
using SalonServices.Dto;
using Salon.Mappings;
using Salon.Web.Tests.Helper;
using SalonServices.Dto.Submission;
using Salon.Models.Submission;

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
    }
}
