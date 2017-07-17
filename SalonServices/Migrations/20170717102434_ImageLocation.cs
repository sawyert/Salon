using Microsoft.EntityFrameworkCore.Migrations;

namespace SalonServices.Migrations
{
    public partial class ImageLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbnailLocation",
                table: "Images",
                maxLength: 300,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbnailLocation",
                table: "Images");
        }
    }
}
