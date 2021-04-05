﻿// <auto-generated />
using System;
using MP.Blazor.Demo.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MP.Blazor.Demo.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210401113847_Update2")]
    partial class Update2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("MP.Blazor.Demo.Core.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observations")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<long>("Version")
                        .IsConcurrencyToken()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products", "dbo");

                    b.HasData(
                        new
                        {
                            Id = new Guid("688a4bab-15a2-4159-bdf8-83cd551995ba"),
                            Active = true,
                            Code = "A123XYZ",
                            CreatedAt = new DateTime(2021, 3, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("95514eb0-50f1-4e13-a7c2-36c7b4984dd8"),
                            Description = "Something Good",
                            Observations = "...",
                            Price = 10m,
                            UpdatedAt = new DateTime(2021, 3, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("95514eb0-50f1-4e13-a7c2-36c7b4984dd8"),
                            Version = 1L
                        },
                        new
                        {
                            Id = new Guid("aadf65a8-d14d-4f87-b25a-cc0b7741db60"),
                            Active = true,
                            Code = "A456XYZ",
                            CreatedAt = new DateTime(2021, 3, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("95514eb0-50f1-4e13-a7c2-36c7b4984dd8"),
                            Description = "Something Expensive",
                            Observations = "...",
                            Price = 155.5m,
                            UpdatedAt = new DateTime(2021, 3, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("95514eb0-50f1-4e13-a7c2-36c7b4984dd8"),
                            Version = 1L
                        },
                        new
                        {
                            Id = new Guid("8befcb97-6cdf-4a40-9511-9197ba715379"),
                            Active = true,
                            Code = "A789XYZ",
                            CreatedAt = new DateTime(2021, 3, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("95514eb0-50f1-4e13-a7c2-36c7b4984dd8"),
                            Description = "Something Cheap",
                            Observations = "...",
                            Price = 1m,
                            UpdatedAt = new DateTime(2021, 3, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("95514eb0-50f1-4e13-a7c2-36c7b4984dd8"),
                            Version = 1L
                        },
                        new
                        {
                            Id = new Guid("810a8c8b-6379-42a9-a223-5f41dff28769"),
                            Active = true,
                            Code = "B159XYZ",
                            CreatedAt = new DateTime(2021, 3, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("95514eb0-50f1-4e13-a7c2-36c7b4984dd8"),
                            Description = "...",
                            Observations = "...",
                            Price = 1m,
                            UpdatedAt = new DateTime(2021, 3, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("95514eb0-50f1-4e13-a7c2-36c7b4984dd8"),
                            Version = 1L
                        },
                        new
                        {
                            Id = new Guid("11063071-7eba-401e-83c7-f411776eada5"),
                            Active = true,
                            Code = "B159XYZ",
                            CreatedAt = new DateTime(2021, 3, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("95514eb0-50f1-4e13-a7c2-36c7b4984dd8"),
                            Description = "...",
                            Observations = "...",
                            Price = 1m,
                            UpdatedAt = new DateTime(2021, 3, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("95514eb0-50f1-4e13-a7c2-36c7b4984dd8"),
                            Version = 1L
                        });
                });

            modelBuilder.Entity("MP.Blazor.Demo.Core.Domain.Entities.WeatherForecast", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("WetherForecasts", "dbo");

                    b.HasData(
                        new
                        {
                            Id = new Guid("688a4bab-15a2-4159-bdf8-83cd551995ba"),
                            Date = new DateTime(2021, 3, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "Sweltering",
                            TemperatureC = -9
                        },
                        new
                        {
                            Id = new Guid("aadf65a8-d14d-4f87-b25a-cc0b7741db60"),
                            Date = new DateTime(2021, 3, 2, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "Balmy",
                            TemperatureC = -20
                        },
                        new
                        {
                            Id = new Guid("8befcb97-6cdf-4a40-9511-9197ba715379"),
                            Date = new DateTime(2021, 3, 3, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "Scorching",
                            TemperatureC = -18
                        },
                        new
                        {
                            Id = new Guid("810a8c8b-6379-42a9-a223-5f41dff28769"),
                            Date = new DateTime(2021, 3, 4, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "Bracing",
                            TemperatureC = 34
                        },
                        new
                        {
                            Id = new Guid("11063071-7eba-401e-83c7-f411776eada5"),
                            Date = new DateTime(2021, 3, 5, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "Freezing",
                            TemperatureC = -12
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
