using NUnit.Framework;
using Salon.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Web.Tests.Unit
{
    [TestFixture]
    class AutoMapperTest
    {
        [Test]
        public void TestWebMapperConfigIsValid()
        {
            // Act
            var config = Mapping.CreateConfiguration();
            // Assert
            config.AssertConfigurationIsValid();

            Assert.IsNotNull(Mapping.Mapper);
        }

        [Test]
        public void CreateConfiguration_SetsMapper()
        {
            // Act
            var config = Mapping.CreateConfiguration();

            // Assert
            Assert.IsNotNull(Mapping.Mapper);
        }
    }
}
