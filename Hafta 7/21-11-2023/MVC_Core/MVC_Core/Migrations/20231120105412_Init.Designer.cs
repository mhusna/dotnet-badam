﻿// <auto-generated />
using System;
using MVC_Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace MVC_Core.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20231120105412_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVC_Core.Models.Brand", b =>
                {
                    b.Property<int>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("BRAND_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NAME");

                    b.HasKey("BrandID");

                    b.ToTable("BRANDS", (string)null);
                });

            modelBuilder.Entity("MVC_Core.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("CATEGORY_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NAME");

                    b.HasKey("CategoryID");

                    b.ToTable("CATEGORIES", (string)null);
                });

            modelBuilder.Entity("MVC_Core.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("PRODUCT_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<int?>("BrandID")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("BRAND_ID");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("CATEGORY_ID");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("IMAGEPATH");

                    b.Property<string>("ImagePath")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NAME");

                    b.Property<double>("Price")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("PRICE");

                    b.HasKey("ProductID");

                    b.HasIndex("BrandID");

                    b.HasIndex("CategoryID");

                    b.ToTable("PRODUCTS", (string)null);
                });

            modelBuilder.Entity("MVC_Core.Models.Product", b =>
                {
                    b.HasOne("MVC_Core.Models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandID");

                    b.HasOne("MVC_Core.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MVC_Core.Models.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MVC_Core.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
