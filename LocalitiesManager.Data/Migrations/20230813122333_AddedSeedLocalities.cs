using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LocalitiesManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedLocalities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Localities",
                columns: new[] { "Id", "CreatedAt", "LocalityTypeId", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5440), 1L, "Красноярск" },
                    { 2L, new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450), 1L, "Ачинск" },
                    { 3L, new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450), 1L, "Лесосибирск" },
                    { 4L, new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450), 1L, "Шарыпово" },
                    { 5L, new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450), 1L, "Дивногорск" },
                    { 6L, new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450), 1L, "Сосновоборск" },
                    { 7L, new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450), 1L, "Ужур" }
                });

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1480));
        }
    }
}
