using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalitiesManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class StreetsTableModelBugFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Streets_Localities_StreetTypeId",
                table: "Streets");

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

            migrationBuilder.CreateIndex(
                name: "IX_Streets_LocalityId",
                table: "Streets",
                column: "LocalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Streets_Localities_LocalityId",
                table: "Streets",
                column: "LocalityId",
                principalTable: "Localities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Streets_Localities_LocalityId",
                table: "Streets");

            migrationBuilder.DropIndex(
                name: "IX_Streets_LocalityId",
                table: "Streets");

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Streets_Localities_StreetTypeId",
                table: "Streets",
                column: "StreetTypeId",
                principalTable: "Localities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
