using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackerApi.Migrations
{
    /// <inheritdoc />
    public partial class RemovedNavProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 6, 12, 5, 3, 536, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 6, 12, 5, 3, 536, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 6, 12, 5, 3, 536, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 6, 12, 5, 3, 536, DateTimeKind.Local).AddTicks(9400));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 6, 12, 2, 53, 582, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 6, 12, 2, 53, 582, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 6, 12, 2, 53, 582, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 6, 12, 2, 53, 582, DateTimeKind.Local).AddTicks(3230));
        }
    }
}
