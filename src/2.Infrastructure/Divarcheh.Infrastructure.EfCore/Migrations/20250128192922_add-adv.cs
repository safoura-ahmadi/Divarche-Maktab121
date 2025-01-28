using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Divarcheh.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class addadv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UserId" },
                values: new object[] { new DateTime(2025, 1, 28, 22, 59, 22, 447, DateTimeKind.Local).AddTicks(1984), 1 });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UserId" },
                values: new object[] { new DateTime(2025, 1, 28, 22, 59, 22, 447, DateTimeKind.Local).AddTicks(1994), 1 });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UserId" },
                values: new object[] { new DateTime(2025, 1, 28, 22, 59, 22, 447, DateTimeKind.Local).AddTicks(1996), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterAt",
                value: new DateTime(2025, 1, 28, 22, 59, 22, 447, DateTimeKind.Local).AddTicks(7297));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UserId" },
                values: new object[] { new DateTime(2025, 1, 28, 22, 56, 17, 714, DateTimeKind.Local).AddTicks(9241), 0 });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UserId" },
                values: new object[] { new DateTime(2025, 1, 28, 22, 56, 17, 714, DateTimeKind.Local).AddTicks(9252), 0 });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UserId" },
                values: new object[] { new DateTime(2025, 1, 28, 22, 56, 17, 714, DateTimeKind.Local).AddTicks(9254), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterAt",
                value: new DateTime(2025, 1, 28, 22, 56, 17, 715, DateTimeKind.Local).AddTicks(4709));
        }
    }
}
