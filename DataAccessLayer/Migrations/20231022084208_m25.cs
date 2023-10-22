using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class m25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Series_Categorys_CategoryId",
                table: "Series");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_Rewiews_SerieRewiewId",
                table: "Series");

            migrationBuilder.DropIndex(
                name: "IX_Series_SerieRewiewId",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "SerieRewiewId",
                table: "Series");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Series",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "RewiewId",
                table: "Series",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Series_RewiewId",
                table: "Series",
                column: "RewiewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Categorys_CategoryId",
                table: "Series",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Rewiews_RewiewId",
                table: "Series",
                column: "RewiewId",
                principalTable: "Rewiews",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Series_Categorys_CategoryId",
                table: "Series");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_Rewiews_RewiewId",
                table: "Series");

            migrationBuilder.DropIndex(
                name: "IX_Series_RewiewId",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "RewiewId",
                table: "Series");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Series",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SerieRewiewId",
                table: "Series",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Series_SerieRewiewId",
                table: "Series",
                column: "SerieRewiewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Categorys_CategoryId",
                table: "Series",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Rewiews_SerieRewiewId",
                table: "Series",
                column: "SerieRewiewId",
                principalTable: "Rewiews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
