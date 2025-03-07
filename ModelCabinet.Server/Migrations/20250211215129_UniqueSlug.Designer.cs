﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModelCabinet.Server.Data;

#nullable disable

namespace ModelCabinet.Server.Migrations
{
    [DbContext(typeof(ModelCabinetContext))]
    [Migration("20250211215129_UniqueSlug")]
    partial class UniqueSlug
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ModelCabinet.Server.Models.Asset", b =>
                {
                    b.Property<int>("AssetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssetId"));

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("AssetId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Asset");

                    b.HasData(
                        new
                        {
                            AssetId = 1,
                            DateCreation = new DateTime(2025, 2, 11, 13, 51, 27, 863, DateTimeKind.Local).AddTicks(4318),
                            DateUpdated = new DateTime(2025, 2, 11, 13, 51, 27, 863, DateTimeKind.Local).AddTicks(4367),
                            FileSize = 446684L,
                            Name = "Test Asset",
                            Path = "Assets\\TestProject\\HelloWorld.stl",
                            ProjectId = 1
                        },
                        new
                        {
                            AssetId = 2,
                            DateCreation = new DateTime(2025, 2, 11, 13, 51, 27, 863, DateTimeKind.Local).AddTicks(4371),
                            DateUpdated = new DateTime(2025, 2, 11, 13, 51, 27, 863, DateTimeKind.Local).AddTicks(4373),
                            FileSize = 11285384L,
                            Name = "Benchy",
                            Path = "Assets\\TestProject\\3DBenchy.stl",
                            ProjectId = 1
                        });
                });

            modelBuilder.Entity("ModelCabinet.Server.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Author = "Author",
                            CreationDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Description",
                            ModifiedDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Test Project",
                            ShortDescription = "Desc",
                            Slug = "nomen-est-omen",
                            Version = "0.0.1"
                        },
                        new
                        {
                            ProjectId = 2,
                            Author = "Author",
                            CreationDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Description",
                            ModifiedDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Test Project Two",
                            ShortDescription = "Desc",
                            Slug = "nomen-est-bonum",
                            Version = "0.0.1"
                        });
                });

            modelBuilder.Entity("ModelCabinet.Server.Models.Asset", b =>
                {
                    b.HasOne("ModelCabinet.Server.Models.Project", null)
                        .WithMany("Assets")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ModelCabinet.Server.Models.Project", b =>
                {
                    b.Navigation("Assets");
                });
#pragma warning restore 612, 618
        }
    }
}
