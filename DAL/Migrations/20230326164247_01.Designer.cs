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
    [Migration("20230326164247_01")]
    partial class _01
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FloorsNumber")
                        .HasColumnType("int");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("RoomsNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("Year")
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
                            Number = 103,
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

                    b.Property<double>("Item")
                        .HasColumnType("float");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.Property<long>("code")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoomID");

                    b.ToTable("furnitures");
                });

            modelBuilder.Entity("DAL.Entity.Inmate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("isPaid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("inmates");
                });

            modelBuilder.Entity("DAL.Entity.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BedsNumder")
                        .HasColumnType("int");

                    b.Property<int?>("DormitoryId")
                        .HasColumnType("int");

                    b.Property<int>("Numder")
                        .HasColumnType("int");

                    b.Property<double>("Payment")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DormitoryId");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("InmateRoom", b =>
                {
                    b.Property<int>("InmateId")
                        .HasColumnType("int");

                    b.Property<int>("RoomsId")
                        .HasColumnType("int");

                    b.HasKey("InmateId", "RoomsId");

                    b.HasIndex("RoomsId");

                    b.ToTable("InmateRoom");
                });

            modelBuilder.Entity("DAL.Entity.Furniture", b =>
                {
                    b.HasOne("DAL.Entity.Room", null)
                        .WithMany("Furniture")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entity.Room", b =>
                {
                    b.HasOne("DAL.Entity.Dormitory", null)
                        .WithMany("Rooms")
                        .HasForeignKey("DormitoryId");
                });

            modelBuilder.Entity("InmateRoom", b =>
                {
                    b.HasOne("DAL.Entity.Inmate", null)
                        .WithMany()
                        .HasForeignKey("InmateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entity.Room", null)
                        .WithMany()
                        .HasForeignKey("RoomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entity.Dormitory", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("DAL.Entity.Room", b =>
                {
                    b.Navigation("Furniture");
                });
#pragma warning restore 612, 618
        }
    }
}
