using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SalonServices.Migrations
{
    public partial class Person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Images",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "CompetitionEntries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_PersonId",
                table: "Images",
                column: "PersonId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Images_People_PersonId",
                table: "Images",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionEntries_People_PersonId",
                table: "CompetitionEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_People_PersonId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropIndex(
                name: "IX_Images_PersonId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_CompetitionEntries_PersonId",
                table: "CompetitionEntries");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "CompetitionEntries");
        }
    }
}
