using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SalonServices
{
    public interface ISalonDbContext
    {
        DbSet<CountryEntity> Countries { get; set; }
        DbSet<AccreditationEntity> Accreditations { get; set; }
        DbSet<AwardLevelEntity> AwardLevels { get; set; }
        DbSet<CircuitEntity> Circuits { get; set; }
        DbSet<CompetitionEntryEntity> CompetitionEntries { get; set; }
        DbSet<ImageEntity> Images { get; set; }
        DbSet<PhotoOrganisationEntity> PhotoOrganisations { get; set; }
        DbSet<SalonEntity> Salons { get; set; }
        DbSet<SalonYearEntity> SalonYears { get; set; }
        DbSet<SectionEntity> SalonSections { get; set; }
        DbSet<SectionTypeEntity> SectionTypes { get; set; }
        DbSet<PersonEntity> People { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
