using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Categorys_CategoryId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_Films_Rewiews_RewiewId",
                table: "Films");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Films",
                table: "Films");

            migrationBuilder.RenameTable(
                name: "Films",
                newName: "Movies");

            migrationBuilder.RenameIndex(
                name: "IX_Films_RewiewId",
                table: "Movies",
                newName: "IX_Movies_RewiewId");

            migrationBuilder.RenameIndex(
                name: "IX_Films_CategoryId",
                table: "Movies",
                newName: "IX_Movies_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categorys_CategoryId",
                table: "Movies",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Rewiews_RewiewId",
                table: "Movies",
                column: "RewiewId",
                principalTable: "Rewiews",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categorys_CategoryId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Rewiews_RewiewId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Films");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_RewiewId",
                table: "Films",
                newName: "IX_Films_RewiewId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CategoryId",
                table: "Films",
                newName: "IX_Films_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Films",
                table: "Films",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Categorys_CategoryId",
                table: "Films",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Rewiews_RewiewId",
                table: "Films",
                column: "RewiewId",
                principalTable: "Rewiews",
                principalColumn: "Id");
        }
    }
}
