using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LocalitiesManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedOwnersSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "CreatedAt", "FirstName", "LastName", "Surname" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6060), "Егор", "Ермаков", "Дмитриевич" },
                    { 2L, new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6070), "Сергей", "Пушкин", "Викторович" }
                });

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6020));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 13, 22, 25, 392, DateTimeKind.Utc).AddTicks(1350));
        }
    }
}
