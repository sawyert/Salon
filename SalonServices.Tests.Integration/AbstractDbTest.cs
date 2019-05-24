using System;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using SalonServices.Mappings;

namespace SalonServices.Tests.Integration
{
    [Category("Integration")]
    public abstract class AbstractDbTest<TDbContext> where TDbContext : DbContext, new()
    {
        protected TDbContext _DbContext;

        [SetUp]
        public virtual void SetUp()
        {
            _DbContext.Database.BeginTransaction();
        }

        [TearDown]
        public virtual void TearDown()
        {
            _DbContext.Database.RollbackTransaction();
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _DbContext = new TDbContext();

            _DbContext.Database.Migrate();

            Mapping.CreateConfiguration();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _DbContext.Database.EnsureDeleted();
        }
    }
}
