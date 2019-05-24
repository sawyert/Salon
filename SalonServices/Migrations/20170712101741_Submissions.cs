using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalonServices.Migrations
{
    public partial class Submissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accreditations_PhotoOrganisations_PhotoOrganisationId",
                table: "Accreditations");

            migrationBuilder.DropForeignKey(
                name: "FK_Accreditations_SalonYears_SalonYearId",
                table: "Accreditations");

            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionEntries_SubmissionEntity_SubmissionEntityId",
                table: "CompetitionEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_SalonSections_SalonYears_SalonYearId",
                table: "SalonSections");

            migrationBuilder.DropForeignKey(
                name: "FK_SalonSections_SectionTypes_SectionTypeId",
                table: "SalonSections");

            migrationBuilder.DropForeignKey(
                name: "FK_SubmissionEntity_People_PersonId",
                table: "SubmissionEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_SubmissionEntity_SalonYears_SalonYearId",
                table: "SubmissionEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubmissionEntity",
                table: "SubmissionEntity");

            migrationBuilder.RenameTable(
                name: "SubmissionEntity",
                newName: "Submissions");

            migrationBuilder.RenameIndex(
                name: "IX_SubmissionEntity_SalonYearId",
                table: "Submissions",
                newName: "IX_Submissions_SalonYearId");

            migrationBuilder.RenameIndex(
                name: "IX_SubmissionEntity_PersonId",
                table: "Submissions",
                newName: "IX_Submissions_PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "SectionTypeId",
                table: "SalonSections",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SalonYearId",
                table: "SalonSections",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SalonYearId",
                table: "Accreditations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PhotoOrganisationId",
                table: "Accreditations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Submissions",
                table: "Submissions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accreditations_PhotoOrganisations_PhotoOrganisationId",
                table: "Accreditations",
                column: "PhotoOrganisationId",
                principalTable: "PhotoOrganisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accreditations_SalonYears_SalonYearId",
                table: "Accreditations",
                column: "SalonYearId",
                principalTable: "SalonYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionEntries_Submissions_SubmissionEntityId",
                table: "CompetitionEntries",
                column: "SubmissionEntityId",
                principalTable: "Submissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalonSections_SalonYears_SalonYearId",
                table: "SalonSections",
                column: "SalonYearId",
                principalTable: "SalonYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalonSections_SectionTypes_SectionTypeId",
                table: "SalonSections",
                column: "SectionTypeId",
                principalTable: "SectionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Submissions_People_PersonId",
                table: "Submissions",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Submissions_SalonYears_SalonYearId",
                table: "Submissions",
                column: "SalonYearId",
                principalTable: "SalonYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accreditations_PhotoOrganisations_PhotoOrganisationId",
                table: "Accreditations");

            migrationBuilder.DropForeignKey(
                name: "FK_Accreditations_SalonYears_SalonYearId",
                table: "Accreditations");

            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionEntries_Submissions_SubmissionEntityId",
                table: "CompetitionEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_SalonSections_SalonYears_SalonYearId",
                table: "SalonSections");

            migrationBuilder.DropForeignKey(
                name: "FK_SalonSections_SectionTypes_SectionTypeId",
                table: "SalonSections");

            migrationBuilder.DropForeignKey(
                name: "FK_Submissions_People_PersonId",
                table: "Submissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Submissions_SalonYears_SalonYearId",
                table: "Submissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Submissions",
                table: "Submissions");

            migrationBuilder.RenameTable(
                name: "Submissions",
                newName: "SubmissionEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Submissions_SalonYearId",
                table: "SubmissionEntity",
                newName: "IX_SubmissionEntity_SalonYearId");

            migrationBuilder.RenameIndex(
                name: "IX_Submissions_PersonId",
                table: "SubmissionEntity",
                newName: "IX_SubmissionEntity_PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "SectionTypeId",
                table: "SalonSections",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SalonYearId",
                table: "SalonSections",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SalonYearId",
                table: "Accreditations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PhotoOrganisationId",
                table: "Accreditations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubmissionEntity",
                table: "SubmissionEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accreditations_PhotoOrganisations_PhotoOrganisationId",
                table: "Accreditations",
                column: "PhotoOrganisationId",
                principalTable: "PhotoOrganisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accreditations_SalonYears_SalonYearId",
                table: "Accreditations",
                column: "SalonYearId",
                principalTable: "SalonYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionEntries_SubmissionEntity_SubmissionEntityId",
                table: "CompetitionEntries",
                column: "SubmissionEntityId",
                principalTable: "SubmissionEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalonSections_SalonYears_SalonYearId",
                table: "SalonSections",
                column: "SalonYearId",
                principalTable: "SalonYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalonSections_SectionTypes_SectionTypeId",
                table: "SalonSections",
                column: "SectionTypeId",
                principalTable: "SectionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubmissionEntity_People_PersonId",
                table: "SubmissionEntity",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubmissionEntity_SalonYears_SalonYearId",
                table: "SubmissionEntity",
                column: "SalonYearId",
                principalTable: "SalonYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
