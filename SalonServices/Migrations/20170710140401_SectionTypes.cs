using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using SalonServices.Entities;

namespace SalonServices.Migrations
{
    public partial class SectionTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            using (var lContext = new SalonDbContext())
            {
                lContext.SectionTypes.AddRange(new List<SectionTypeEntity>{ new SectionTypeEntity
                {
                    Name = "Open Colour",
                    IsPrint = false,
                    SectionCode = "PIDC_M",
                },
                new SectionTypeEntity
                {
                    Name = "Open Mono",
                    IsPrint = false,
                    SectionCode = "PIDC_M",
                },
                new SectionTypeEntity
                {
                    Name = "Nature",
                    IsPrint = false,
                    SectionCode = "NATURE",
                },new SectionTypeEntity
                {
                    Name = "Creative",
                    IsPrint = false,
                    SectionCode = "CREATIVE",
                },
                });

                lContext.SaveChanges();
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
