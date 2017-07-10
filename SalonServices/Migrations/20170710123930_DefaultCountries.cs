using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using SalonServices.Entities;

namespace SalonServices.Migrations
{
    public partial class DefaultCountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            using (var lContext = new SalonDbContext())
            {
                lContext.Countries.AddRange(new List<CountryEntity>{ new CountryEntity
                {
                    Name = "India"
                },
                new CountryEntity
                {
                    Name = "England"
                },
                new CountryEntity
                {
                    Name = "USA"
                }
                });

                lContext.SaveChanges();
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
