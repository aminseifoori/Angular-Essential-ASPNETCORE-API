using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Angular_Essential_API.Migrations
{
    /// <inheritdoc />
    public partial class onetomanyrelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_ActorsMovies_MovieId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_ActorsMovies_ActorId",
                table: "Actors");

            migrationBuilder.DropTable(
                name: "ActorsMovies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropIndex(
                name: "IX_Movies_MovieId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "Costs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MovieID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Costs_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Costs",
                columns: new[] { "Id", "Amount", "MovieID" },
                values: new object[,]
                {
                    { new Guid("2f0e1e03-9438-4d46-9809-5f530ca12345"), 13254784.00m, new Guid("c40dea06-64c2-4e32-b1be-66de42062ec2") },
                    { new Guid("2f0e1e03-9438-4d46-9809-5f530ca12346"), 1500.00m, new Guid("c8a235b0-0764-49c5-b930-74ec0951c388") },
                    { new Guid("2f0e1e03-9438-4d46-9809-5f530ca12347"), 154785441.22m, new Guid("06f158fe-277f-469b-adb3-878e3ec53e63") },
                    { new Guid("2f0e1e03-9438-4d46-9809-5f530ca12348"), 145254.25m, new Guid("06f158fe-277f-469b-adb3-878e3ec53e63") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Costs_MovieID",
                table: "Costs",
                column: "MovieID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Costs");

            migrationBuilder.AddColumn<Guid>(
                name: "MovieId",
                table: "Movies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorsMovies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorsMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActorsMovies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorsMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorId", "Name" },
                values: new object[,]
                {
                    { new Guid("2f0e1e03-9438-4d46-9809-5f530ca9193b"), null, "Nicolas Cage" },
                    { new Guid("318756e3-08af-472b-baa7-8506f8921f26"), null, "John Travolta" },
                    { new Guid("40671866-d43d-4f5d-9d6b-9c844e53c671"), null, "Robert Deniro" },
                    { new Guid("965fa160-3c70-4a8b-a6cf-9c3a449b1601"), null, "Alpacino" }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("06f158fe-277f-469b-adb3-878e3ec53e63"),
                column: "MovieId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c1deebaa-8e9e-4340-9b89-d63c451c0061"),
                column: "MovieId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c40dea06-64c2-4e32-b1be-66de42062ec2"),
                column: "MovieId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c8a235b0-0764-49c5-b930-74ec0951c388"),
                column: "MovieId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e01976fe-6f54-4197-bcb6-0e4c79b173a1"),
                column: "MovieId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f135c973-e378-4a9d-820c-f1fe1c8b764a"),
                column: "MovieId",
                value: null);

            migrationBuilder.InsertData(
                table: "ActorsMovies",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("15137445-f014-4dd0-a1a9-da22bc8e58d2"), new Guid("40671866-d43d-4f5d-9d6b-9c844e53c671"), new Guid("e01976fe-6f54-4197-bcb6-0e4c79b173a1") },
                    { new Guid("7cb7f516-4dbb-4064-9be8-7cb43fd046b1"), new Guid("318756e3-08af-472b-baa7-8506f8921f26"), new Guid("06f158fe-277f-469b-adb3-878e3ec53e63") },
                    { new Guid("bc8dd89d-5145-432a-bd9c-8fdcd19e52cd"), new Guid("2f0e1e03-9438-4d46-9809-5f530ca9193b"), new Guid("06f158fe-277f-469b-adb3-878e3ec53e63") },
                    { new Guid("e64caef3-77fd-410f-a58e-d335cf5a7f68"), new Guid("965fa160-3c70-4a8b-a6cf-9c3a449b1601"), new Guid("e01976fe-6f54-4197-bcb6-0e4c79b173a1") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieId",
                table: "Movies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Actors_ActorId",
                table: "Actors",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorsMovies_ActorId",
                table: "ActorsMovies",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorsMovies_MovieId",
                table: "ActorsMovies",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_ActorsMovies_MovieId",
                table: "Movies",
                column: "MovieId",
                principalTable: "ActorsMovies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_ActorsMovies_ActorId",
                table: "Actors",
                column: "ActorId",
                principalTable: "ActorsMovies",
                principalColumn: "Id");
        }
    }
}
