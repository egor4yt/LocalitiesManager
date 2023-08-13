using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LocalitiesManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalityTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    Prefix = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalityTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StreetTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    Prefix = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    LocalityTypeId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Localities_LocalityTypes_LocalityTypeId",
                        column: x => x.LocalityTypeId,
                        principalTable: "LocalityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Streets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    StreetTypeId = table.Column<long>(type: "bigint", nullable: false),
                    LocalityId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Streets_Localities_StreetTypeId",
                        column: x => x.StreetTypeId,
                        principalTable: "Localities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Streets_StreetTypes_StreetTypeId",
                        column: x => x.StreetTypeId,
                        principalTable: "StreetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    StreetId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Houses_Streets_StreetId",
                        column: x => x.StreetId,
                        principalTable: "Streets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    HouseId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartments_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OwnerApartmentRelation",
                columns: table => new
                {
                    ApartmentId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerApartmentRelation", x => new { x.OwnerId, x.ApartmentId });
                    table.ForeignKey(
                        name: "FK_OwnerApartmentRelation_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OwnerApartmentRelation_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LocalityTypes",
                columns: new[] { "Id", "CreatedAt", "Name", "Prefix" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1400), "Город", "г." },
                    { 2L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1400), "Посёлок", "п." },
                    { 3L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1400), "Посёлок городского типа", "пгт." },
                    { 4L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1400), "Деревня", "д." },
                    { 5L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1400), "Село", "с." },
                    { 6L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410), "Рабочий посёлок", "рп." },
                    { 7L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410), "Курортный посёлок", "кп." },
                    { 8L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410), "Кишлак", "к." },
                    { 9L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410), "Дачный посёлок", "дп." },
                    { 10L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410), "Посёлок при станции", "п.ст." },
                    { 11L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410), "Местечко", "м." },
                    { 12L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410), "Слобода", "сл." },
                    { 13L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1410), "Станция", "ст." }
                });

            migrationBuilder.InsertData(
                table: "StreetTypes",
                columns: new[] { "Id", "CreatedAt", "Name", "Prefix" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1460), "Улица", "ул." },
                    { 2L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1460), "Переулок", "пер." },
                    { 3L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1460), "Проспект", "пр-кт." },
                    { 4L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470), "Микрорайон", "мкр." },
                    { 5L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470), "Линия", "л." },
                    { 6L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470), "Дорога", "дор." },
                    { 7L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470), "Линия", "лн." },
                    { 8L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470), "Ряд", "ряд" },
                    { 9L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470), "Сквер", "с-р" },
                    { 10L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470), "Тракт", "тракт" },
                    { 11L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470), "Шоссе", "ш." },
                    { 12L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1470), "Набережная", "наб." },
                    { 13L, new DateTime(2023, 8, 13, 9, 10, 7, 887, DateTimeKind.Utc).AddTicks(1480), "Магистраль", "мгстр." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_HouseId",
                table: "Apartments",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_StreetId",
                table: "Houses",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "IX_Localities_LocalityTypeId",
                table: "Localities",
                column: "LocalityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerApartmentRelation_ApartmentId",
                table: "OwnerApartmentRelation",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Streets_StreetTypeId",
                table: "Streets",
                column: "StreetTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OwnerApartmentRelation");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "Streets");

            migrationBuilder.DropTable(
                name: "Localities");

            migrationBuilder.DropTable(
                name: "StreetTypes");

            migrationBuilder.DropTable(
                name: "LocalityTypes");
        }
    }
}
