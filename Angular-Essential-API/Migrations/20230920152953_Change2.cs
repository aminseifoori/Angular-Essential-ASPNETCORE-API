using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Angular_Essential_API.Migrations
{
    /// <inheritdoc />
    public partial class Change2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovie");

            migrationBuilder.CreateIndex(
                name: "IX_ActorsMovies_ActorId",
                table: "ActorsMovies",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorsMovies_MovieId",
                table: "ActorsMovies",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsMovies_Actors_ActorId",
                table: "ActorsMovies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsMovies_Movies_MovieId",
                table: "ActorsMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorsMovies_Actors_ActorId",
                table: "ActorsMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_ActorsMovies_Movies_MovieId",
                table: "ActorsMovies");

            migrationBuilder.DropIndex(
                name: "IX_ActorsMovies_ActorId",
                table: "ActorsMovies");

            migrationBuilder.DropIndex(
                name: "IX_ActorsMovies_MovieId",
                table: "ActorsMovies");

            migrationBuilder.CreateTable(
                name: "ActorMovie",
                columns: table => new
                {
                    ActortsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MoviesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovie", x => new { x.ActortsId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_ActorMovie_Actors_ActortsId",
                        column: x => x.ActortsId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_MoviesId",
                table: "ActorMovie",
                column: "MoviesId");
        }
    }
}
