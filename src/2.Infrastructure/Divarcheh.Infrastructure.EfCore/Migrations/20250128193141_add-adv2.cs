using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Divarcheh.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class addadv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 1, 28, 23, 1, 41, 184, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 1, 28, 23, 1, 41, 184, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 1, 28, 23, 1, 41, 184, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "AdvertisementFinalStatus", "AdvertisementStatus", "AdvertisementType", "ApprovedAt", "BrandId", "CategoryId", "CityId", "CreateAt", "Description", "Model", "Price", "Title", "UserId", "VisitCount" },
                values: new object[] { 4, 2, 0, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 6, 10, new DateTime(2025, 1, 28, 23, 1, 41, 184, DateTimeKind.Local).AddTicks(9566), "Description", "2024", 70000, "سامسونگ گلکسی اس 10", 1, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterAt",
                value: new DateTime(2025, 1, 28, 23, 1, 41, 185, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "AdvertisementId", "Path" },
                values: new object[] { 5, 4, "Images/trending/5.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 1, 28, 22, 59, 22, 447, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 1, 28, 22, 59, 22, 447, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 1, 28, 22, 59, 22, 447, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterAt",
                value: new DateTime(2025, 1, 28, 22, 59, 22, 447, DateTimeKind.Local).AddTicks(7297));
        }
    }
}
