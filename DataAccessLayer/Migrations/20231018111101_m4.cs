using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Rewiews_FilmRewiewRewiewId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_Rewiews_SerieRewiewRewiewId",
                table: "Series");

            migrationBuilder.RenameColumn(
                name: "SerieRewiewRewiewId",
                table: "Series",
                newName: "SerieRewiewId");

            migrationBuilder.RenameColumn(
                name: "SerieId",
                table: "Series",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Series_SerieRewiewRewiewId",
                table: "Series",
                newName: "IX_Series_SerieRewiewId");

            migrationBuilder.RenameColumn(
                name: "RewiewId",
                table: "Rewiews",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FilmRewiewRewiewId",
                table: "Films",
                newName: "FilmRewiewId");

            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "Films",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Films_FilmRewiewRewiewId",
                table: "Films",
                newName: "IX_Films_FilmRewiewId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categorys",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Series",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Series",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DelegationCreatedBy",
                table: "Series",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DelegationUpdatedBy",
                table: "Series",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Series",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Series",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Series",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewiews",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Rewiews",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DelegationCreatedBy",
                table: "Rewiews",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DelegationUpdatedBy",
                table: "Rewiews",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Rewiews",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Rewiews",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Rewiews",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Films",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Films",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DelegationCreatedBy",
                table: "Films",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DelegationUpdatedBy",
                table: "Films",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Films",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Films",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Films",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Categorys",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Categorys",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DelegationCreatedBy",
                table: "Categorys",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DelegationUpdatedBy",
                table: "Categorys",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Categorys",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categorys",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Categorys",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Rewiews_FilmRewiewId",
                table: "Films",
                column: "FilmRewiewId",
                principalTable: "Rewiews",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Rewiews_FilmRewiewId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_Rewiews_SerieRewiewId",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "DelegationCreatedBy",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "DelegationUpdatedBy",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Rewiews");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Rewiews");

            migrationBuilder.DropColumn(
                name: "DelegationCreatedBy",
                table: "Rewiews");

            migrationBuilder.DropColumn(
                name: "DelegationUpdatedBy",
                table: "Rewiews");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Rewiews");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Rewiews");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Rewiews");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "DelegationCreatedBy",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "DelegationUpdatedBy",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "DelegationCreatedBy",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "DelegationUpdatedBy",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Categorys");

            migrationBuilder.RenameColumn(
                name: "SerieRewiewId",
                table: "Series",
                newName: "SerieRewiewRewiewId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Series",
                newName: "SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Series_SerieRewiewId",
                table: "Series",
                newName: "IX_Series_SerieRewiewRewiewId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Rewiews",
                newName: "RewiewId");

            migrationBuilder.RenameColumn(
                name: "FilmRewiewId",
                table: "Films",
                newName: "FilmRewiewRewiewId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Films",
                newName: "FilmId");

            migrationBuilder.RenameIndex(
                name: "IX_Films_FilmRewiewId",
                table: "Films",
                newName: "IX_Films_FilmRewiewRewiewId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categorys",
                newName: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Rewiews_FilmRewiewRewiewId",
                table: "Films",
                column: "FilmRewiewRewiewId",
                principalTable: "Rewiews",
                principalColumn: "RewiewId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Rewiews_SerieRewiewRewiewId",
                table: "Series",
                column: "SerieRewiewRewiewId",
                principalTable: "Rewiews",
                principalColumn: "RewiewId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
