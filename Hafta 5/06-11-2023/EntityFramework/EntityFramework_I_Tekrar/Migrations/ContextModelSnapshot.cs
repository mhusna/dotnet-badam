﻿// <auto-generated />
using EntityFramework_I_Tekrar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace EntityFramework_I_Tekrar.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityFramework_I_Tekrar.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("CATEGORY_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 4L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("CHAR(30)")
                        .HasColumnName("CATEGORY_NAME");

                    b.HasKey("CategoryID");

                    b.ToTable("CATEGORIES", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Kırtasiye"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Elektronik"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Tekstil"
                        });
                });

            modelBuilder.Entity("EntityFramework_I_Tekrar.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("PRODUCT_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("CATEGORY_ID");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("PRODUCT_NAME");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("PRODUCT_PRICE");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("PRODUCTS", (string)null);
                });

            modelBuilder.Entity("EntityFramework_I_Tekrar.Models.Product", b =>
                {
                    b.HasOne("EntityFramework_I_Tekrar.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityFramework_I_Tekrar.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}