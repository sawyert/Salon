using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;

namespace SalonServices
{
    public class SalonDbContext : DbContext, ISalonDbContext, IDbTransaction
    {
        public virtual DbSet<CountryEntity> Countries { get; set; }
        public virtual DbSet<AccreditationEntity> Accreditations { get; set; }
        public virtual DbSet<AwardLevelEntity> AwardLevels { get; set; }
        public virtual DbSet<CircuitEntity> Circuits { get; set; }
        public virtual DbSet<CompetitionEntryEntity> CompetitionEntries { get; set; }
        public virtual DbSet<ImageEntity> Images { get; set; }
        public virtual DbSet<PhotoOrganisationEntity> PhotoOrganisations { get; set; }
        public virtual DbSet<SalonEntity> Salons { get; set; }
        public virtual DbSet<SalonYearEntity> SalonYears { get; set; }
        public virtual DbSet<SectionEntity> SalonSections { get; set; }
        public virtual DbSet<SectionTypeEntity> SectionTypes { get; set; }
        public virtual DbSet<PersonEntity> People { get; set; }
        public virtual DbSet<SubmissionEntity> Submissions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetAppSettingsConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonEntity>().HasMany(per => per.Images).WithOne(img => img.Person).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PersonEntity>().HasMany(per => per.Submissions).WithOne(ent => ent.Person).OnDelete(DeleteBehavior.Restrict);

        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await this.Database.BeginTransactionAsync();
        }
        

        /// <summary>
        /// Gets the connection string from the app setting
        /// </summary>
        /// <returns></returns>
        private static string GetAppSettingsConnectionString()
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(AppContext.BaseDirectory)
             .AddJsonFile("appsettings.json", false);

            var config = builder.Build();

            var connstr = config.GetConnectionString("Salon");
            return connstr;
        }

    }
}
