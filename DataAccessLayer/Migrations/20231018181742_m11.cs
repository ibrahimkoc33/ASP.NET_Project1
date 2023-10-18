using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class m11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Rewiews_FilmRewiewId",
                table: "Films");

            migrationBuilder.RenameColumn(
                name: "FilmRewiewId",
                table: "Films",
                newName: "MovieRewiewId");

            migrationBuilder.RenameIndex(
                name: "IX_Films_FilmRewiewId",
                table: "Films",
                newName: "IX_Films_MovieRewiewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Rewiews_MovieRewiewId",
                table: "Films",
                column: "MovieRewiewId",
                principalTable: "Rewiews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Rewiews_MovieRewiewId",
                table: "Films");

            migrationBuilder.RenameColumn(
                name: "MovieRewiewId",
                table: "Films",
                newName: "FilmRewiewId");

            migrationBuilder.RenameIndex(
                name: "IX_Films_MovieRewiewId",
                table: "Films",
                newName: "IX_Films_FilmRewiewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Rewiews_FilmRewiewId",
                table: "Films",
                column: "FilmRewiewId",
                principalTable: "Rewiews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
