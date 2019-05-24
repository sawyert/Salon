using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalonServices.Migrations
{
    public partial class SectionTypesFlagOnOrg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkWithSectionTypes",
                table: "AwardLevels");

            migrationBuilder.AddColumn<bool>(
                name: "EnableSectionTypes",
                table: "PhotoOrganisations",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnableSectionTypes",
                table: "PhotoOrganisations");

            migrationBuilder.AddColumn<bool>(
                name: "WorkWithSectionTypes",
                table: "AwardLevels",
                nullable: false,
                defaultValue: false);
        }
    }
}
