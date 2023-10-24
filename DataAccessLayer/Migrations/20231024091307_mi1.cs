using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mi1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Star",
                table: "Series",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "RunTime",
                table: "Series",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RunTime",
                table: "Series");

            migrationBuilder.AlterColumn<int>(
                name: "Star",
                table: "Series",
                type: "integer",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
