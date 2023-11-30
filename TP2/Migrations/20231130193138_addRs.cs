using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP2.Migrations
{
    public partial class addRs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GenreId",
                table: "movies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "GenreId",
                table: "genres",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_movies_GenreId",
                table: "movies",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_genres_GenreId",
                table: "genres",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_genres_genres_GenreId",
                table: "genres",
                column: "GenreId",
                principalTable: "genres",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_movies_genres_GenreId",
                table: "movies",
                column: "GenreId",
                principalTable: "genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_genres_genres_GenreId",
                table: "genres");

            migrationBuilder.DropForeignKey(
                name: "FK_movies_genres_GenreId",
                table: "movies");

            migrationBuilder.DropIndex(
                name: "IX_movies_GenreId",
                table: "movies");

            migrationBuilder.DropIndex(
                name: "IX_genres_GenreId",
                table: "genres");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "genres");
        }
    }
}
