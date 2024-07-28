using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Your_Health.server.Migrations
{
    /// <inheritdoc />
    public partial class seedingRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Manager", "MANAGER" },
                    { "3", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 29, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 30, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 31, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 8, 1, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 8, 2, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 8, 3, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 8, 4, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 8, 5, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 8, 6, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 8, 7, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 8, 8, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 8, 9, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 8, 10, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 8, 11, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 8, 12, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 8, 13, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 8, 14, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 8, 15, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 8, 16, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 8, 17, 18, 13, 31, 465, DateTimeKind.Local).AddTicks(4480));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 28, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 29, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 30, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 31, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 8, 1, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 8, 2, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 8, 3, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 8, 4, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 8, 5, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 8, 6, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 8, 7, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 8, 8, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 8, 9, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 8, 10, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 8, 11, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 8, 12, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 8, 13, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 8, 14, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 8, 15, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "AppointmentId",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 8, 16, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9722));
        }
    }
}
