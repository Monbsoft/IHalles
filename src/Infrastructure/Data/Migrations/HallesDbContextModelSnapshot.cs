﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Monbsoft.IHalles.Infrastructure.Data;

namespace Monbsoft.IHalles.Infrastructure.Data.Migrations
{
    [DbContext(typeof(HallesDbContext))]
    partial class HallesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Monbsoft.IHalles.Application.Models.Halle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Updated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Halles");
                });

            modelBuilder.Entity("Monbsoft.IHalles.Application.Models.Halle", b =>
                {
                    b.OwnsOne("Monbsoft.IHalles.Application.Models.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("HalleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Region")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.HasKey("HalleId");

                            b1.ToTable("Halles");

                            b1.WithOwner()
                                .HasForeignKey("HalleId");
                        });

                    b.OwnsOne("Monbsoft.IHalles.Application.Models.Location", "Location", b1 =>
                        {
                            b1.Property<Guid>("HalleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<double>("Latitude")
                                .HasColumnType("float");

                            b1.Property<double>("Longitude")
                                .HasColumnType("float");

                            b1.HasKey("HalleId");

                            b1.ToTable("Halles");

                            b1.WithOwner()
                                .HasForeignKey("HalleId");
                        });

                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Location")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
