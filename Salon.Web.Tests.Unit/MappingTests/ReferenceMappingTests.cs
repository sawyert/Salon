﻿using NUnit.Framework;
using Salon.Mappings;
using Salon.Models;
using Salon.Models.Submission;
using Salon.Web.Tests.Helper;
using SalonServices.Dto;
using SalonServices.Dto.Submission;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Web.Tests.Unit.MappingTests
{
    public class ReferenceMappingTests
    {
        [SetUp]
        public void Setup()
        {
            Mapping.CreateConfiguration();
        }

        [Test]
        public void MapCircuitViewModelToDto()
        {
            MappingTestHelpers.MapFromModelAndBack<CircuitViewModel, CircuitDto>();
        }

        [Test]
        public void MapOrgModelToDtoAndBack()
        {
            MappingTestHelpers.MapFromModelAndBack<OrganisationViewModel, OrganisationDto>();
        }

        [Test]
        public void MapSectionTypeViewModelToDto()
        {
            MappingTestHelpers.MapFromModelAndBack<SectionTypeViewModel, SectionTypeDto>();
        }

        [Test]
        public void MapCountryViewModelToDto()
        {
            MappingTestHelpers.MapFromModelAndBack<CountryViewModel, CountryDto>();
        }
    }
}
