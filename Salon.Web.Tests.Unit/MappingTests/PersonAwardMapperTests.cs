using GenFu;
using NUnit.Framework;
using Salon.Models;
using SalonServices.Dto;
using Salon.Mappings;
using Salon.Web.Tests.Helper;

namespace Salon.Web.Tests.Unit.MappingTests
{
    [TestFixture]
    public class PersonAwardMapperTests
    {
        [SetUp]
        public void Setup()
        {
            Mapping.CreateConfiguration();
        }

        [Test]
        public void MapPersonVmToBasicPersonDto()
        {
            MappingTestHelpers.MapFromModelAndBack<BasicPersonViewModel, BasicPersonDto>();
        }

        [Test]
        public void MapPersonAwardTableVmToBasicPersonDto()
        {
            A.Configure<PersonAwardTableViewModel>()
            .Fill(p => p.Organisations, () => A.ListOf<PersonAwardTableOrgViewModel>());

            A.Configure<PersonAwardTableOrgViewModel>()
           .Fill(p => p.Awards, () => A.ListOf<PersonAwardTableRowViewModel>());

            MappingTestHelpers.MapFromModelAndBack<PersonAwardTableViewModel, PersonAwardTableDto>();
        }
    }
}
