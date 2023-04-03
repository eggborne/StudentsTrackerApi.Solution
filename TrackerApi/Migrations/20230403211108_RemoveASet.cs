using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackerApi.Migrations
{
    /// <inheritdoc />
    public partial class RemoveASet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 3, 14, 11, 8, 594, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 3, 14, 11, 8, 594, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 3, 14, 11, 8, 594, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 3, 14, 11, 8, 594, DateTimeKind.Local).AddTicks(2580));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 3, 14, 4, 45, 53, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 3, 14, 4, 45, 53, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 3, 14, 4, 45, 53, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 3, 14, 4, 45, 53, DateTimeKind.Local).AddTicks(8750));
        }
    }
}
