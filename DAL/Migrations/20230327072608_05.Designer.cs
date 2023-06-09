﻿// <auto-generated />
using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230327072608_05")]
    partial class _05
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entity.Dormitory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FloorsNumber")
                        .HasColumnType("int");

                    b.Property<string>("Manager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Number")
                        .HasColumnType("int");

                    b.Property<int?>("RoomsNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("dormitories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Chernivtsi, Nebesnoyi Sotni 4B",
                            FloorsNumber = 5,
                            Manager = "Valera",
                            Number = 3,
                            RoomsNumber = 50,
                            Year = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DAL.Entity.Furniture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Year")
                        .HasColumnType("datetime2");

                    b.Property<long?>("code")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("furnitures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Item = "шафа",
                            RoomId = 1,
                            Year = new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            code = 68234354L
                        });
                });

            modelBuilder.Entity("DAL.Entity.Inmate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("isPaid")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("inmates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Misha",
                            RoomId = 1,
                            Status = "student",
                            Surname = "Hordashuk",
                            isPaid = true
                        },
                        new
                        {
                            Id = 2,
                            Name = "Vasia",
                            RoomId = 1,
                            Status = "student",
                            Surname = "Fammilia",
                            isPaid = true
                        });
                });

            modelBuilder.Entity("DAL.Entity.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BedsNumder")
                        .HasColumnType("int");

                    b.Property<int>("DormintoryId")
                        .HasColumnType("int");

                    b.Property<int?>("DormitoryId")
                        .HasColumnType("int");

                    b.Property<int?>("Numder")
                        .HasColumnType("int");

                    b.Property<double?>("Payment")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DormitoryId");

                    b.ToTable("rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BedsNumder = 2,
                            DormintoryId = 0,
                            Numder = 116,
                            Payment = 2000.0
                        });
                });

            modelBuilder.Entity("DAL.Entity.Furniture", b =>
                {
                    b.HasOne("DAL.Entity.Room", null)
                        .WithMany("Furnitures")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("DAL.Entity.Inmate", b =>
                {
                    b.HasOne("DAL.Entity.Room", null)
                        .WithMany("Inmates")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("DAL.Entity.Room", b =>
                {
                    b.HasOne("DAL.Entity.Dormitory", null)
                        .WithMany("Rooms")
                        .HasForeignKey("DormitoryId");
                });

            modelBuilder.Entity("DAL.Entity.Dormitory", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("DAL.Entity.Room", b =>
                {
                    b.Navigation("Furnitures");

                    b.Navigation("Inmates");
                });
#pragma warning restore 612, 618
        }
    }
}
