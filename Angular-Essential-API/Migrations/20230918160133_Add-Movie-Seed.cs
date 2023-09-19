using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Angular_Essential_API.Migrations
{
    /// <inheritdoc />
    public partial class AddMovieSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { new Guid("06f158fe-277f-469b-adb3-878e3ec53e63"), "Face Off", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c1deebaa-8e9e-4340-9b89-d63c451c0061"), "God Father 4", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c40dea06-64c2-4e32-b1be-66de42062ec2"), "God Father 1", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c8a235b0-0764-49c5-b930-74ec0951c388"), "God Father 1", new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e01976fe-6f54-4197-bcb6-0e4c79b173a1"), "God Father 2", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f135c973-e378-4a9d-820c-f1fe1c8b764a"), "God Father 3", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("06f158fe-277f-469b-adb3-878e3ec53e63"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c1deebaa-8e9e-4340-9b89-d63c451c0061"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c40dea06-64c2-4e32-b1be-66de42062ec2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c8a235b0-0764-49c5-b930-74ec0951c388"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e01976fe-6f54-4197-bcb6-0e4c79b173a1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f135c973-e378-4a9d-820c-f1fe1c8b764a"));
        }
    }
}
