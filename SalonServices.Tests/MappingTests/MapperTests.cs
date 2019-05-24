using NUnit.Framework;
using SalonServices.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Tests
{
    [TestFixture]
    public class MapperTests
    {
        [Test]
        public void TestConfigIsValid()
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
