using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackerApi.Migrations
{
    /// <inheritdoc />
    public partial class Promotions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 6, 9, 4, 0, 316, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 6, 9, 4, 0, 316, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 6, 9, 4, 0, 316, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 6, 9, 4, 0, 316, DateTimeKind.Local).AddTicks(9340));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 5, 9, 22, 42, 389, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 5, 9, 22, 42, 389, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 5, 9, 22, 42, 389, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "DateEnrolled",
                value: new DateTime(2023, 4, 5, 9, 22, 42, 389, DateTimeKind.Local).AddTicks(6290));
        }
    }
}
