using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class m7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Overview",
                table: "Rewiews");

            migrationBuilder.AddColumn<string>(
                name: "Overview",
                table: "Series",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Overview",
                table: "Series");

            migrationBuilder.AddColumn<string>(
                name: "Overview",
                table: "Rewiews",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
