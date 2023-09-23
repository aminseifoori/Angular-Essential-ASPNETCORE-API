using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Angular_Essential_API.Migrations
{
    /// <inheritdoc />
    public partial class AddActorSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[,]
                {
                    { new Guid("2f0e1e03-9438-4d46-9809-5f530ca9193b"), new Guid("06f158fe-277f-469b-adb3-878e3ec53e63"), "Nicolas Cage" },
                    { new Guid("318756e3-08af-472b-baa7-8506f8921f26"), new Guid("06f158fe-277f-469b-adb3-878e3ec53e63"), "John Travolta" },
                    { new Guid("40671866-d43d-4f5d-9d6b-9c844e53c671"), new Guid("e01976fe-6f54-4197-bcb6-0e4c79b173a1"), "Robert Deniro" },
                    { new Guid("965fa160-3c70-4a8b-a6cf-9c3a449b1601"), new Guid("e01976fe-6f54-4197-bcb6-0e4c79b173a1"), "Alpacino" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("2f0e1e03-9438-4d46-9809-5f530ca9193b"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("318756e3-08af-472b-baa7-8506f8921f26"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("40671866-d43d-4f5d-9d6b-9c844e53c671"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("965fa160-3c70-4a8b-a6cf-9c3a449b1601"));
        }
    }
}
