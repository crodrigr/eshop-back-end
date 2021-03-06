﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using catalog.api;

namespace catalog.api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210209163332_carga datos")]
    partial class cargadatos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("catalog.api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<double>("PurchasePrice")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Apple MacBook Pro is a macOS laptop with a 13.30-inch display that has a resolution of 2560x1600 pixels",
                            Name = "MacBook",
                            PurchasePrice = 2000.0,
                            Quantity = 10,
                            SalePrice = 2300.0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Active noise cancellation for immersive sound. Transparency mode for hearing and connecting with the world around you",
                            Name = "Apple - AirPods Pro - White",
                            PurchasePrice = 150.0,
                            Quantity = 10,
                            SalePrice = 190.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "Bring a theater experience to your home with this Sony BRAVIA 77-inch OLED 4K HDR TV.",
                            Name = "Smart Android TV Sony - 77 TV Class A9G OLED 4K UHD ",
                            PurchasePrice = 3500.0,
                            Quantity = 10,
                            SalePrice = 3900.0
                        },
                        new
                        {
                            Id = 4,
                            Description = "The iPhone 12 features a 6.1-inch (15.3-cm) display with Super Retina XDR OLED technology at a resolution of 2532×1170 pixels and a pixel density of about 460 ppi",
                            Name = "iPhone 12",
                            PurchasePrice = 900.0,
                            Quantity = 10,
                            SalePrice = 1200.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
