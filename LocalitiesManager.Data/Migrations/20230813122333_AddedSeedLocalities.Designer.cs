﻿// <auto-generated />
using System;
using LocalitiesManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LocalitiesManager.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230813122333_AddedSeedLocalities")]
    partial class AddedSeedLocalities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LocalitiesManager.Data.Entities.Apartment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("HouseId")
                        .HasColumnType("bigint");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.House", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<long>("StreetId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("StreetId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.Locality", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("LocalityTypeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("LocalityTypeId");

                    b.ToTable("Localities");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5440),
                            LocalityTypeId = 1L,
                            Name = "Красноярск"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450),
                            LocalityTypeId = 1L,
                            Name = "Ачинск"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450),
                            LocalityTypeId = 1L,
                            Name = "Лесосибирск"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450),
                            LocalityTypeId = 1L,
                            Name = "Шарыпово"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450),
                            LocalityTypeId = 1L,
                            Name = "Дивногорск"
                        },
                        new
                        {
                            Id = 6L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450),
                            LocalityTypeId = 1L,
                            Name = "Сосновоборск"
                        },
                        new
                        {
                            Id = 7L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5450),
                            LocalityTypeId = 1L,
                            Name = "Ужур"
                        });
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.LocalityType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Prefix")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("LocalityTypes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5320),
                            Name = "Город",
                            Prefix = "г."
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5330),
                            Name = "Посёлок",
                            Prefix = "п."
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5330),
                            Name = "Посёлок городского типа",
                            Prefix = "пгт."
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5330),
                            Name = "Деревня",
                            Prefix = "д."
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5330),
                            Name = "Село",
                            Prefix = "с."
                        },
                        new
                        {
                            Id = 6L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5340),
                            Name = "Рабочий посёлок",
                            Prefix = "рп."
                        },
                        new
                        {
                            Id = 7L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5340),
                            Name = "Курортный посёлок",
                            Prefix = "кп."
                        },
                        new
                        {
                            Id = 8L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5340),
                            Name = "Кишлак",
                            Prefix = "к."
                        },
                        new
                        {
                            Id = 9L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5340),
                            Name = "Дачный посёлок",
                            Prefix = "дп."
                        },
                        new
                        {
                            Id = 10L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5350),
                            Name = "Посёлок при станции",
                            Prefix = "п.ст."
                        },
                        new
                        {
                            Id = 11L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5350),
                            Name = "Местечко",
                            Prefix = "м."
                        },
                        new
                        {
                            Id = 12L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5350),
                            Name = "Слобода",
                            Prefix = "сл."
                        },
                        new
                        {
                            Id = 13L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5350),
                            Name = "Станция",
                            Prefix = "ст."
                        });
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.Owner", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Surname")
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.OwnerApartmentRelation", b =>
                {
                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<long>("ApartmentId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.HasKey("OwnerId", "ApartmentId");

                    b.HasIndex("ApartmentId");

                    b.ToTable("OwnerApartmentRelation");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.Street", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("LocalityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<long>("StreetTypeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("StreetTypeId");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.StreetType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Prefix")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("StreetTypes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5410),
                            Name = "Улица",
                            Prefix = "ул."
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5410),
                            Name = "Переулок",
                            Prefix = "пер."
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5410),
                            Name = "Проспект",
                            Prefix = "пр-кт."
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5410),
                            Name = "Микрорайон",
                            Prefix = "мкр."
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5410),
                            Name = "Линия",
                            Prefix = "л."
                        },
                        new
                        {
                            Id = 6L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420),
                            Name = "Дорога",
                            Prefix = "дор."
                        },
                        new
                        {
                            Id = 7L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420),
                            Name = "Линия",
                            Prefix = "лн."
                        },
                        new
                        {
                            Id = 8L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420),
                            Name = "Ряд",
                            Prefix = "ряд"
                        },
                        new
                        {
                            Id = 9L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420),
                            Name = "Сквер",
                            Prefix = "с-р"
                        },
                        new
                        {
                            Id = 10L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420),
                            Name = "Тракт",
                            Prefix = "тракт"
                        },
                        new
                        {
                            Id = 11L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420),
                            Name = "Шоссе",
                            Prefix = "ш."
                        },
                        new
                        {
                            Id = 12L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420),
                            Name = "Набережная",
                            Prefix = "наб."
                        },
                        new
                        {
                            Id = 13L,
                            CreatedAt = new DateTime(2023, 8, 13, 12, 23, 33, 72, DateTimeKind.Utc).AddTicks(5420),
                            Name = "Магистраль",
                            Prefix = "мгстр."
                        });
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.Apartment", b =>
                {
                    b.HasOne("LocalitiesManager.Data.Entities.House", "House")
                        .WithMany("Apartments")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("House");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.House", b =>
                {
                    b.HasOne("LocalitiesManager.Data.Entities.Street", "Street")
                        .WithMany("Houses")
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Street");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.Locality", b =>
                {
                    b.HasOne("LocalitiesManager.Data.Entities.LocalityType", "LocalityType")
                        .WithMany("Localities")
                        .HasForeignKey("LocalityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocalityType");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.OwnerApartmentRelation", b =>
                {
                    b.HasOne("LocalitiesManager.Data.Entities.Apartment", "Apartment")
                        .WithMany("OwnerApartmentRelations")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LocalitiesManager.Data.Entities.Owner", "Owner")
                        .WithMany("OwnerApartmentRelations")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartment");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.Street", b =>
                {
                    b.HasOne("LocalitiesManager.Data.Entities.Locality", "Locality")
                        .WithMany("Streets")
                        .HasForeignKey("StreetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LocalitiesManager.Data.Entities.StreetType", "StreetType")
                        .WithMany("Streets")
                        .HasForeignKey("StreetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Locality");

                    b.Navigation("StreetType");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.Apartment", b =>
                {
                    b.Navigation("OwnerApartmentRelations");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.House", b =>
                {
                    b.Navigation("Apartments");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.Locality", b =>
                {
                    b.Navigation("Streets");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.LocalityType", b =>
                {
                    b.Navigation("Localities");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.Owner", b =>
                {
                    b.Navigation("OwnerApartmentRelations");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.Street", b =>
                {
                    b.Navigation("Houses");
                });

            modelBuilder.Entity("LocalitiesManager.Data.Entities.StreetType", b =>
                {
                    b.Navigation("Streets");
                });
#pragma warning restore 612, 618
        }
    }
}
