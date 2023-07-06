using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaApp.Migrations
{
    public partial class Title2AddedIntoFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Features",
                newName: "Title2");

            migrationBuilder.AddColumn<string>(
                name: "Title1",
                table: "Features",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title1",
                table: "Features");

            migrationBuilder.RenameColumn(
                name: "Title2",
                table: "Features",
                newName: "Title");
        }
    }
}
