﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Monbsoft.IHalles.Infrastructure.Data;

namespace Monbsoft.IHalles.Infrastructure.Data.Migrations
{
    [DbContext(typeof(IHallesDbContext))]
    partial class IHallesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Monbsoft.IHalles.Application.Models.IHalle", b =>
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

                    b.ToTable("IHalles");
                });

            modelBuilder.Entity("Monbsoft.IHalles.Application.Models.IHalle", b =>
                {
                    b.OwnsOne("Monbsoft.IHalles.Application.Models.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("IHalleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("PostalCode")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Region")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("IHalleId");

                            b1.ToTable("IHalles");

                            b1.WithOwner()
                                .HasForeignKey("IHalleId");
                        });

                    b.OwnsOne("Monbsoft.IHalles.Application.Models.Location", "Location", b1 =>
                        {
                            b1.Property<Guid>("IHalleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<double>("Latitude")
                                .HasColumnType("float");

                            b1.Property<double>("Longitude")
                                .HasColumnType("float");

                            b1.HasKey("IHalleId");

                            b1.ToTable("IHalles");

                            b1.WithOwner()
                                .HasForeignKey("IHalleId");
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
