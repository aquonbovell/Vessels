﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Vessels.Data;

#nullable disable

namespace Vessels.Data
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240812204922_inti")]
    partial class inti
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Vessels.Models.Vessel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Vessels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArrivalDate = new DateTime(2024, 8, 12, 16, 49, 22, 94, DateTimeKind.Local).AddTicks(9373),
                            DepartureDate = new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ship 1",
                            Status = "Intransit"
                        },
                        new
                        {
                            Id = 3,
                            ArrivalDate = new DateTime(2024, 8, 12, 16, 49, 22, 94, DateTimeKind.Local).AddTicks(9417),
                            DepartureDate = new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ship 2",
                            Status = "Loading"
                        },
                        new
                        {
                            Id = 5,
                            ArrivalDate = new DateTime(2024, 8, 12, 16, 49, 22, 94, DateTimeKind.Local).AddTicks(9419),
                            DepartureDate = new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ship 3",
                            Status = "Docked"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
