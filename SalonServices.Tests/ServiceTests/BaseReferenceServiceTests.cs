using NSubstitute;
using NUnit.Framework;
using SalonServices.Mappings;
using SalonServices.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Tests.Unit.ServiceTests
{
    public abstract class BaseReferenceServiceTests
    {
        protected ICountryRepository _countryRepository;
        protected ISectionTypeRepository _sectionTypeRepository;
        protected IPhotoOrganisationRepository _photoOrganisationRepository;
        protected ICircuitRepository _circuitRepository;
        protected ReferenceServices referenceServices;

        [SetUp]
        public void Setup()
        {
            this._countryRepository = Substitute.For<ICountryRepository>();
            this._sectionTypeRepository = Substitute.For<ISectionTypeRepository>();
            this._photoOrganisationRepository = Substitute.For<IPhotoOrganisationRepository>();
            this._circuitRepository = Substitute.For<ICircuitRepository>();

            this.referenceServices = new ReferenceServices(this._countryRepository, this._sectionTypeRepository, this._photoOrganisationRepository, this._circuitRepository);

            Mapping.CreateConfiguration();
        }
    }
}
