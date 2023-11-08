using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class m8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categorys_CategoryId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Rewiews_MovieId",
                table: "Rewiews");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Movies",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rewiews_MovieId",
                table: "Rewiews",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categorys_CategoryId",
                table: "Movies",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categorys_CategoryId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Rewiews_MovieId",
                table: "Rewiews");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Movies",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_Rewiews_MovieId",
                table: "Rewiews",
                column: "MovieId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categorys_CategoryId",
                table: "Movies",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id");
        }
    }
}
