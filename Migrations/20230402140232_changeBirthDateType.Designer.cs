﻿// <auto-generated />
using System;
using CitizenManagementSystemAPI.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CitizenManagementSystemAPI.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20230402140232_changeBirthDateType")]
    partial class changeBirthDateType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.Citizen", b =>
                {
                    b.Property<int>("CitizenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CitizenId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<int>("BirthPlaceId")
                        .HasColumnType("integer");

                    b.Property<int>("CurrentPlaceId")
                        .HasColumnType("integer");

                    b.Property<int?>("FatherId")
                        .HasColumnType("integer");

                    b.Property<int>("GenderId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<int?>("MotherId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Pin")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CitizenId");

                    b.HasIndex("BirthPlaceId");

                    b.HasIndex("CurrentPlaceId");

                    b.HasIndex("FatherId");

                    b.HasIndex("GenderId");

                    b.HasIndex("MotherId");

                    b.ToTable("Citizens");
                });

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.CurrentPlace", b =>
                {
                    b.Property<int>("CurrentPlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CurrentPlaceId"));

                    b.Property<int>("EntranceId")
                        .HasColumnType("integer");

                    b.Property<int>("RegionId")
                        .HasColumnType("integer");

                    b.Property<int>("StreetId")
                        .HasColumnType("integer");

                    b.HasKey("CurrentPlaceId");

                    b.HasIndex("EntranceId");

                    b.HasIndex("RegionId");

                    b.HasIndex("StreetId");

                    b.ToTable("CurrentPlaces");
                });

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.Entrance", b =>
                {
                    b.Property<int>("EntranceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EntranceId"));

                    b.Property<string>("EntranceName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StreetId")
                        .HasColumnType("integer");

                    b.HasKey("EntranceId");

                    b.HasIndex("StreetId");

                    b.ToTable("Entrances");
                });

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.EnumKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EnumKeys");
                });

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.EnumValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("KeyId")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("KeyId");

                    b.ToTable("EnumValues");
                });

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.Manager", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ManagerId"));

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ManagerId");

                    b.ToTable("Managers");

                    b.HasData(
                        new
                        {
                            ManagerId = 1,
                            IsDeleted = false,
                            Name = "Nurlan",
                            Password = "password",
                            Surname = "Khankishiyev",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RegionId"));

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RegionId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.Street", b =>
                {
                    b.Property<int>("StreetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StreetId"));

                    b.Property<int>("RegionId")
                        .HasColumnType("integer");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("StreetId");

                    b.HasIndex("RegionId");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.Citizen", b =>
                {
                    b.HasOne("CitizenManagementSystemAPI.Entities.Region", "BirthPlace")
                        .WithMany()
                        .HasForeignKey("BirthPlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CitizenManagementSystemAPI.Entities.CurrentPlace", "CurrentPlace")
                        .WithMany()
                        .HasForeignKey("CurrentPlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CitizenManagementSystemAPI.Entities.Citizen", "Father")
                        .WithMany()
                        .HasForeignKey("FatherId");

                    b.HasOne("CitizenManagementSystemAPI.Entities.EnumValue", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CitizenManagementSystemAPI.Entities.Citizen", "Mother")
                        .WithMany()
                        .HasForeignKey("MotherId");

                    b.Navigation("BirthPlace");

                    b.Navigation("CurrentPlace");

                    b.Navigation("Father");

                    b.Navigation("Gender");

                    b.Navigation("Mother");
                });

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.CurrentPlace", b =>
                {
                    b.HasOne("CitizenManagementSystemAPI.Entities.Entrance", "Entrance")
                        .WithMany()
                        .HasForeignKey("EntranceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CitizenManagementSystemAPI.Entities.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CitizenManagementSystemAPI.Entities.Street", "Street")
                        .WithMany()
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entrance");

                    b.Navigation("Region");

                    b.Navigation("Street");
                });

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.Entrance", b =>
                {
                    b.HasOne("CitizenManagementSystemAPI.Entities.Street", "Street")
                        .WithMany("Entrances")
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Street");
                });

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.EnumValue", b =>
                {
                    b.HasOne("CitizenManagementSystemAPI.Entities.EnumKey", "Key")
                        .WithMany()
                        .HasForeignKey("KeyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Key");
                });

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.Street", b =>
                {
                    b.HasOne("CitizenManagementSystemAPI.Entities.Region", "Region")
                        .WithMany("Streets")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.Region", b =>
                {
                    b.Navigation("Streets");
                });

            modelBuilder.Entity("CitizenManagementSystemAPI.Entities.Street", b =>
                {
                    b.Navigation("Entrances");
                });
#pragma warning restore 612, 618
        }
    }
}
