using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class m20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Categorys_CategoryId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_Films_Rewiews_MovieRewiewId",
                table: "Films");

            migrationBuilder.DropIndex(
                name: "IX_Films_MovieRewiewId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "MovieRewiewId",
                table: "Films");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Films",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "RewiewId",
                table: "Films",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Films_RewiewId",
                table: "Films",
                column: "RewiewId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Categorys_CategoryId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_Films_Rewiews_RewiewId",
                table: "Films");

            migrationBuilder.DropIndex(
                name: "IX_Films_RewiewId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "RewiewId",
                table: "Films");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Films",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieRewiewId",
                table: "Films",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Films_MovieRewiewId",
                table: "Films",
                column: "MovieRewiewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Categorys_CategoryId",
                table: "Films",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Rewiews_MovieRewiewId",
                table: "Films",
                column: "MovieRewiewId",
                principalTable: "Rewiews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
