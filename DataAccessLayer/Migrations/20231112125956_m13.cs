using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class m13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Movies",
                newName: "Dateee");

            migrationBuilder.AddColumn<int>(
                name: "Datee",
                table: "Movies",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Datee",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "Dateee",
                table: "Movies",
                newName: "Date");
        }
    }
}
