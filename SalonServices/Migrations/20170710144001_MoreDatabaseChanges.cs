using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SalonServices.Migrations
{
    public partial class MoreDatabaseChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionEntries_People_PersonId",
                table: "CompetitionEntries");

            migrationBuilder.DropIndex(
                name: "IX_CompetitionEntries_PersonId",
                table: "CompetitionEntries");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "CompetitionEntries");

            migrationBuilder.AddColumn<DateTime>(
                name: "CataloguesPostedDate",
                table: "SalonYears",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosingDate",
                table: "SalonYears",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "JudgeDate",
                table: "SalonYears",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NotificationDate",
                table: "SalonYears",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "CompetitionEntries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAwarded",
                table: "CompetitionEntries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "CompetitionEntries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubmissionEntityId",
                table: "CompetitionEntries",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SubmissionEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntryCost = table.Column<decimal>(type: "Money", nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    IsJudged = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(maxLength: 1000, nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    SalonYearId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubmissionEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubmissionEntity_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubmissionEntity_SalonYears_SalonYearId",
                        column: x => x.SalonYearId,
                        principalTable: "SalonYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionEntries_SubmissionEntityId",
                table: "CompetitionEntries",
                column: "SubmissionEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_SubmissionEntity_PersonId",
                table: "SubmissionEntity",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SubmissionEntity_SalonYearId",
                table: "SubmissionEntity",
                column: "SalonYearId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionEntries_SubmissionEntity_SubmissionEntityId",
                table: "CompetitionEntries",
                column: "SubmissionEntityId",
                principalTable: "SubmissionEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionEntries_SubmissionEntity_SubmissionEntityId",
                table: "CompetitionEntries");

            migrationBuilder.DropTable(
                name: "SubmissionEntity");

            migrationBuilder.DropIndex(
                name: "IX_CompetitionEntries_SubmissionEntityId",
                table: "CompetitionEntries");

            migrationBuilder.DropColumn(
                name: "CataloguesPostedDate",
                table: "SalonYears");

            migrationBuilder.DropColumn(
                name: "ClosingDate",
                table: "SalonYears");

            migrationBuilder.DropColumn(
                name: "JudgeDate",
                table: "SalonYears");

            migrationBuilder.DropColumn(
                name: "NotificationDate",
                table: "SalonYears");

            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "CompetitionEntries");

            migrationBuilder.DropColumn(
                name: "IsAwarded",
                table: "CompetitionEntries");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "CompetitionEntries");

            migrationBuilder.DropColumn(
                name: "SubmissionEntityId",
                table: "CompetitionEntries");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "CompetitionEntries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionEntries_PersonId",
                table: "CompetitionEntries",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionEntries_People_PersonId",
                table: "CompetitionEntries",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
