using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeWorkTracker_Test.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "LastUpdate" },
                values: new object[] { new DateTime(2024, 4, 28, 21, 11, 0, 466, DateTimeKind.Local).AddTicks(2293), new DateTime(2024, 4, 28, 21, 11, 0, 466, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "LastUpdate" },
                values: new object[] { new DateTime(2024, 4, 25, 21, 11, 0, 466, DateTimeKind.Local).AddTicks(2348), new DateTime(2024, 4, 28, 21, 11, 0, 466, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "LastUpdate" },
                values: new object[] { new DateTime(2024, 4, 24, 22, 11, 0, 466, DateTimeKind.Local).AddTicks(2354), new DateTime(2024, 4, 28, 21, 11, 0, 466, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "LastUpdate" },
                values: new object[] { new DateTime(2024, 4, 20, 18, 11, 0, 466, DateTimeKind.Local).AddTicks(2359), new DateTime(2024, 4, 28, 21, 11, 0, 466, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "LastUpdate" },
                values: new object[] { new DateTime(2024, 4, 21, 14, 11, 0, 466, DateTimeKind.Local).AddTicks(2363), new DateTime(2024, 4, 28, 21, 11, 0, 466, DateTimeKind.Local).AddTicks(2364) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "LastUpdate" },
                values: new object[] { new DateTime(2024, 4, 28, 20, 1, 24, 668, DateTimeKind.Local).AddTicks(9476), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "LastUpdate" },
                values: new object[] { new DateTime(2024, 4, 25, 20, 1, 24, 668, DateTimeKind.Local).AddTicks(9530), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "LastUpdate" },
                values: new object[] { new DateTime(2024, 4, 24, 21, 1, 24, 668, DateTimeKind.Local).AddTicks(9535), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "LastUpdate" },
                values: new object[] { new DateTime(2024, 4, 20, 17, 1, 24, 668, DateTimeKind.Local).AddTicks(9538), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "LastUpdate" },
                values: new object[] { new DateTime(2024, 4, 21, 13, 1, 24, 668, DateTimeKind.Local).AddTicks(9542), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
