﻿// <auto-generated />
using System;
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(KimiaCharmContext))]
    [Migration("20220302112948_edit_model_product_mig")]
    partial class edit_model_product_mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Models.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CartID");

                    b.ToTable("Cart");

                    b.HasData(
                        new
                        {
                            CartID = 1,
                            TotalPrice = 0m
                        });
                });

            modelBuilder.Entity("DataLayer.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartItemID");

                    b.HasIndex("CartID");

                    b.HasIndex("ProductID")
                        .IsUnique();

                    b.ToTable("CartItem");

                    b.HasData(
                        new
                        {
                            CartItemID = 1,
                            CartID = 1,
                            ProductID = 1,
                            Quantity = 2
                        },
                        new
                        {
                            CartItemID = 2,
                            CartID = 1,
                            ProductID = 2,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("DataLayer.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Name = "کیف"
                        },
                        new
                        {
                            CategoryID = 2,
                            Name = "جاهندزفری"
                        });
                });

            modelBuilder.Entity("DataLayer.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorizontalImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Keywords")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VerticalImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CategoryID = 1,
                            Date = new DateTime(2022, 3, 2, 14, 59, 47, 810, DateTimeKind.Local).AddTicks(745),
                            FullDescription = "کیف زنانه در رنگ های متنوع و ساخته شده با چرم طبیعی با قیمتی باور نکردنی ",
                            HorizontalImageName = "1.jpg",
                            IsAvailable = true,
                            Keywords = "کیف;کفش;کیف زنانه;چرم;چرم طبیعی;کیمیا مهر",
                            Name = "کیف چرمی زنانه",
                            Price = 200000m,
                            ShortDescription = "یک کیف چرمی زنانه بسیار با کیفیت",
                            VerticalImageName = "1.jpg"
                        },
                        new
                        {
                            ProductID = 2,
                            CategoryID = 2,
                            Date = new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(149),
                            FullDescription = "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ",
                            HorizontalImageName = "2.jpg",
                            IsAvailable = false,
                            Keywords = "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر",
                            Name = "کیف چرمی مردانه",
                            Price = 300000m,
                            ShortDescription = "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت",
                            VerticalImageName = "2.jpg"
                        },
                        new
                        {
                            ProductID = 3,
                            CategoryID = 1,
                            Date = new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(225),
                            FullDescription = "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ",
                            HorizontalImageName = "3.jpg",
                            IsAvailable = false,
                            Keywords = "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر",
                            Name = "کیف چرمی مردانه",
                            Price = 300000m,
                            ShortDescription = "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت",
                            VerticalImageName = "3.jpg"
                        },
                        new
                        {
                            ProductID = 4,
                            CategoryID = 2,
                            Date = new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(230),
                            FullDescription = "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ",
                            HorizontalImageName = "4.jpg",
                            IsAvailable = false,
                            Keywords = "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر",
                            Name = "کیف چرمی مردانه",
                            Price = 300000m,
                            ShortDescription = "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت",
                            VerticalImageName = "4.jpg"
                        },
                        new
                        {
                            ProductID = 5,
                            CategoryID = 1,
                            Date = new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(233),
                            FullDescription = "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ",
                            HorizontalImageName = "5.jpg",
                            IsAvailable = false,
                            Keywords = "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر",
                            Name = "کیف چرمی مردانه",
                            Price = 300000m,
                            ShortDescription = "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت",
                            VerticalImageName = "5.jpg"
                        },
                        new
                        {
                            ProductID = 6,
                            CategoryID = 1,
                            Date = new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(236),
                            FullDescription = "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ",
                            HorizontalImageName = "6.jpg",
                            IsAvailable = false,
                            Keywords = "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر",
                            Name = "کیف چرمی مردانه",
                            Price = 300000m,
                            ShortDescription = "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت",
                            VerticalImageName = "6.jpg"
                        },
                        new
                        {
                            ProductID = 7,
                            CategoryID = 2,
                            Date = new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(239),
                            FullDescription = "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ",
                            HorizontalImageName = "7.jpg",
                            IsAvailable = false,
                            Keywords = "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر",
                            Name = "کیف چرمی مردانه",
                            Price = 300000m,
                            ShortDescription = "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت",
                            VerticalImageName = "7.jpg"
                        },
                        new
                        {
                            ProductID = 8,
                            CategoryID = 1,
                            Date = new DateTime(2022, 3, 2, 14, 59, 47, 812, DateTimeKind.Local).AddTicks(241),
                            FullDescription = "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ",
                            HorizontalImageName = "8.jpg",
                            IsAvailable = false,
                            Keywords = "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر",
                            Name = "کیف چرمی مردانه",
                            Price = 300000m,
                            ShortDescription = "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت",
                            VerticalImageName = "8.jpg"
                        });
                });

            modelBuilder.Entity("DataLayer.Models.CartItem", b =>
                {
                    b.HasOne("DataLayer.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Models.Product", "Product")
                        .WithOne("CartItem")
                        .HasForeignKey("DataLayer.Models.CartItem", "ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataLayer.Models.Product", b =>
                {
                    b.HasOne("DataLayer.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
