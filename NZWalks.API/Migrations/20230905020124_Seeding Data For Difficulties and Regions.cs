using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9888c8e3-a1f9-41a8-bf33-51408b8f2b6f"), "Hard" },
                    { new Guid("a92fae55-9d0b-42c2-9059-ad8a9ff2f9fd"), "Medium" },
                    { new Guid("d540cc5f-695f-4574-a344-a84e71b19245"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("51d30169-4e7e-45b4-adf6-1cd23d218f9f"), "STL", "Southland", null },
                    { new Guid("5bbe10c0-b919-4d6e-bec4-7829bc31354b"), "WGN", "Wellington", null },
                    { new Guid("7d687386-1603-4033-850d-a0a7af0645df"), "NSN", "Nelson", null },
                    { new Guid("939a074a-4bc7-4254-a669-ac4d473b9f56"), "NTL", "Northland", null },
                    { new Guid("c030fb34-6cc6-4165-9431-68f5914d48c4"), "AKL", "Auckland", null },
                    { new Guid("e91d50f3-0884-436f-86af-28927d34b1e9"), "BOP", "Bay of Plenty", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("9888c8e3-a1f9-41a8-bf33-51408b8f2b6f"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("a92fae55-9d0b-42c2-9059-ad8a9ff2f9fd"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("d540cc5f-695f-4574-a344-a84e71b19245"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("51d30169-4e7e-45b4-adf6-1cd23d218f9f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5bbe10c0-b919-4d6e-bec4-7829bc31354b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("7d687386-1603-4033-850d-a0a7af0645df"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("939a074a-4bc7-4254-a669-ac4d473b9f56"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c030fb34-6cc6-4165-9431-68f5914d48c4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e91d50f3-0884-436f-86af-28927d34b1e9"));
        }
    }
}
