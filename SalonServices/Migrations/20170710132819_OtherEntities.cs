using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SalonServices.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Circuits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Notes = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhotoOrganisations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoOrganisations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Website = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salons_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SectionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsPrint = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    SectionCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AwardLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MinimumAcceptances = table.Column<int>(nullable: false),
                    MinimumAwards = table.Column<int>(nullable: false),
                    MinimumCountries = table.Column<int>(nullable: false),
                    MinimumDistinctImages = table.Column<int>(nullable: false),
                    MinimumPrints = table.Column<int>(nullable: false),
                    MinimumSalons = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    PhotoOrganisationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardLevels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AwardLevels_PhotoOrganisations_PhotoOrganisationId",
                        column: x => x.PhotoOrganisationId,
                        principalTable: "PhotoOrganisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalonYears",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CircuitId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    SalonId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalonYears", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalonYears_Circuits_CircuitId",
                        column: x => x.CircuitId,
                        principalTable: "Circuits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalonYears_Salons_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accreditations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhotoOrganisationId = table.Column<int>(nullable: true),
                    SalonNumber = table.Column<string>(maxLength: 20, nullable: false),
                    SalonYearId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accreditations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accreditations_PhotoOrganisations_PhotoOrganisationId",
                        column: x => x.PhotoOrganisationId,
                        principalTable: "PhotoOrganisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accreditations_SalonYears_SalonYearId",
                        column: x => x.SalonYearId,
                        principalTable: "SalonYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalonSections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SalonYearId = table.Column<int>(nullable: true),
                    SectionTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalonSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalonSections_SalonYears_SalonYearId",
                        column: x => x.SalonYearId,
                        principalTable: "SalonYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalonSections_SectionTypes_SectionTypeId",
                        column: x => x.SectionTypeId,
                        principalTable: "SectionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionEntries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageId = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompetitionEntries_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionEntries_SalonSections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "SalonSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accreditations_PhotoOrganisationId",
                table: "Accreditations",
                column: "PhotoOrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_Accreditations_SalonYearId",
                table: "Accreditations",
                column: "SalonYearId");

            migrationBuilder.CreateIndex(
                name: "IX_AwardLevels_PhotoOrganisationId",
                table: "AwardLevels",
                column: "PhotoOrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionEntries_ImageId",
                table: "CompetitionEntries",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionEntries_SectionId",
                table: "CompetitionEntries",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Salons_CountryId",
                table: "Salons",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SalonYears_CircuitId",
                table: "SalonYears",
                column: "CircuitId");

            migrationBuilder.CreateIndex(
                name: "IX_SalonYears_SalonId",
                table: "SalonYears",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_SalonSections_SalonYearId",
                table: "SalonSections",
                column: "SalonYearId");

            migrationBuilder.CreateIndex(
                name: "IX_SalonSections_SectionTypeId",
                table: "SalonSections",
                column: "SectionTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accreditations");

            migrationBuilder.DropTable(
                name: "AwardLevels");

            migrationBuilder.DropTable(
                name: "CompetitionEntries");

            migrationBuilder.DropTable(
                name: "PhotoOrganisations");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "SalonSections");

            migrationBuilder.DropTable(
                name: "SalonYears");

            migrationBuilder.DropTable(
                name: "SectionTypes");

            migrationBuilder.DropTable(
                name: "Circuits");

            migrationBuilder.DropTable(
                name: "Salons");
        }
    }
}
