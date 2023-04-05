using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackerApi.Migrations
{
    /// <inheritdoc />
    public partial class RemovedAdultBool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adult",
                table: "Students");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Adult",
                table: "Students",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                columns: new[] { "Adult", "DateEnrolled" },
                values: new object[] { false, new DateTime(2023, 4, 3, 14, 11, 8, 594, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                columns: new[] { "Adult", "DateEnrolled" },
                values: new object[] { false, new DateTime(2023, 4, 3, 14, 11, 8, 594, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                columns: new[] { "Adult", "DateEnrolled" },
                values: new object[] { false, new DateTime(2023, 4, 3, 14, 11, 8, 594, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                columns: new[] { "Adult", "DateEnrolled" },
                values: new object[] { false, new DateTime(2023, 4, 3, 14, 11, 8, 594, DateTimeKind.Local).AddTicks(2580) });
        }
    }
}
