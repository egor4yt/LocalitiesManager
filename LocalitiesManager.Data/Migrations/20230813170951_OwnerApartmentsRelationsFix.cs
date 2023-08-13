using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LocalitiesManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class OwnerApartmentsRelationsFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnerApartmentRelation_Apartments_ApartmentId",
                table: "OwnerApartmentRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerApartmentRelation_Owners_OwnerId",
                table: "OwnerApartmentRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OwnerApartmentRelation",
                table: "OwnerApartmentRelation");

            migrationBuilder.RenameTable(
                name: "OwnerApartmentRelation",
                newName: "OwnerApartmentRelations");

            migrationBuilder.RenameIndex(
                name: "IX_OwnerApartmentRelation_ApartmentId",
                table: "OwnerApartmentRelations",
                newName: "IX_OwnerApartmentRelations_ApartmentId");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "OwnerApartmentRelations",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OwnerApartmentRelations",
                table: "OwnerApartmentRelations",
                columns: new[] { "OwnerId", "ApartmentId" });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "LocalityTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "StreetTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 17, 9, 51, 405, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerApartmentRelations_Apartments_ApartmentId",
                table: "OwnerApartmentRelations",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerApartmentRelations_Owners_OwnerId",
                table: "OwnerApartmentRelations",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnerApartmentRelations_Apartments_ApartmentId",
                table: "OwnerApartmentRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerApartmentRelations_Owners_OwnerId",
                table: "OwnerApartmentRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OwnerApartmentRelations",
                table: "OwnerApartmentRelations");

            migrationBuilder.RenameTable(
                name: "OwnerApartmentRelations",
                newName: "OwnerApartmentRelation");

            migrationBuilder.RenameIndex(
                name: "IX_OwnerApartmentRelations_ApartmentId",
                table: "OwnerApartmentRelation",
                newName: "IX_OwnerApartmentRelation_ApartmentId");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "OwnerApartmentRelation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OwnerApartmentRelation",
                table: "OwnerApartmentRelation",
                columns: new[] { "OwnerId", "ApartmentId" });

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

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 13, 14, 15, 16, 390, DateTimeKind.Utc).AddTicks(6070));

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

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerApartmentRelation_Apartments_ApartmentId",
                table: "OwnerApartmentRelation",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerApartmentRelation_Owners_OwnerId",
                table: "OwnerApartmentRelation",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
