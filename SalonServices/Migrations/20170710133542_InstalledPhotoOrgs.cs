using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using SalonServices.Entities;

namespace SalonServices.Migrations
{
    public partial class InstalledPhotoOrgs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            using (var lContext = new SalonDbContext())
            {
                lContext.PhotoOrganisations.AddRange(new List<PhotoOrganisationEntity>{ new PhotoOrganisationEntity
                {
                    Name = "FIAP",
                    AwardLevels = new List<AwardLevelEntity>{
                        new AwardLevelEntity{
                            Name = "AFIAP",
                            MinimumAcceptances = 40,
                            MinimumCountries = 8,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 15,
                            MinimumSalons = 15,
                            MinimumPrints = 4,
                        },
                        new AwardLevelEntity{
                            Name = "EFIAP",
                            MinimumAcceptances = 250,
                            MinimumCountries = 20,
                            MinimumAwards = 2,
                            MinimumDistinctImages = 50,
                            MinimumSalons = 30,
                            MinimumPrints = 12,
                        },
                    }
                },
                new PhotoOrganisationEntity
                {
                    Name = "PSA",
                    AwardLevels = new List<AwardLevelEntity>{
                        new AwardLevelEntity{
                            Name = "PSA 1*",
                            MinimumAcceptances = 18,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 6,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "PSA 2*",
                            MinimumAcceptances = 36,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 12,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "PSA 3*",
                            MinimumAcceptances = 72,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 24,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "PSA 4*",
                            MinimumAcceptances = 144,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 48,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "PSA 5*",
                            MinimumAcceptances = 288,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 96,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                    }
                },
                new PhotoOrganisationEntity
                {
                    Name = "BPE",
                    AwardLevels = new List<AwardLevelEntity>{
                        new AwardLevelEntity{
                            Name = "BPE 1*",
                            MinimumAcceptances = 25,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 0,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "BPE 2*",
                            MinimumAcceptances = 50,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 0,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "BPE 3*",
                            MinimumAcceptances = 100,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 0,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "BPE 4*",
                            MinimumAcceptances = 200,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 0,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "BPE 5*",
                            MinimumAcceptances = 300,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 0,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                    }
                } });

                lContext.SaveChanges();
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
