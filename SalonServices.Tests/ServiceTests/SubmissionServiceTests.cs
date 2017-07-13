using NSubstitute;
using NUnit.Framework;
using SalonServices.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Tests.Unit.ServiceTests
{
    [TestFixture]
    public class SubmissionServiceTests
    {
        private SubmissionService submissionService;

        [SetUp]
        public void Setup()
        {

            this.submissionService = new SubmissionService();

            Mapping.CreateConfiguration();
        }

    }
}
