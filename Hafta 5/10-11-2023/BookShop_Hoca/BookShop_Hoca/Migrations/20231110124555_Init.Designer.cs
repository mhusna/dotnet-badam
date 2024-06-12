﻿// <auto-generated />
using System;
using BookShop_Hoca.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace BookShop_Hoca.Migrations
{
    [DbContext(typeof(KitapContext))]
    [Migration("20231110124555_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookShop_Hoca.Models.Kitap", b =>
                {
                    b.Property<int>("KitapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("KITAP_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KitapID"), 1L, 1);

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("EKLEME_TARIHI");

                    b.Property<double>("Fiyat")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("FIYAT");

                    b.Property<string>("KitapAdi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)")
                        .HasColumnName("KITAP_ADI");

                    b.Property<int>("KitapDurumu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasDefaultValue(1)
                        .HasColumnName("KITAP_DURUMU");

                    b.Property<int>("StokAdedi")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("STOK_ADEDI");

                    b.Property<int?>("YayinEviID")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("YAYINEVI_ID");

                    b.HasKey("KitapID");

                    b.HasIndex("YayinEviID");

                    b.ToTable("KITAPLAR", (string)null);
                });

            modelBuilder.Entity("BookShop_Hoca.Models.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("KULLANICI_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KullaniciID"), 2L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("AD");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("SIFRE");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("SOYAD");

                    b.HasKey("KullaniciID");

                    b.ToTable("KULLANICILAR", (string)null);

                    b.HasData(
                        new
                        {
                            KullaniciID = 1,
                            Ad = "Cevdet",
                            KullaniciAdi = "cevdo",
                            Sifre = "75a0afaec2c629a4dfbb1e8c8cdeb352",
                            Soyad = "Korkmaz"
                        });
                });

            modelBuilder.Entity("BookShop_Hoca.Models.Yayinevi", b =>
                {
                    b.Property<int>("YayinEviID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("YAYINEVI_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YayinEviID"), 4L, 1);

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("ADRES");

                    b.Property<string>("YayinEviAdi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)")
                        .HasColumnName("YAYINEVI_ADI");

                    b.HasKey("YayinEviID");

                    b.ToTable("YAYINEVLERI", (string)null);

                    b.HasData(
                        new
                        {
                            YayinEviID = 1,
                            Adres = "Kadıköy",
                            YayinEviAdi = "Alfa"
                        },
                        new
                        {
                            YayinEviID = 2,
                            Adres = "Sisli",
                            YayinEviAdi = "Is Bankasi Yayinlari"
                        },
                        new
                        {
                            YayinEviID = 3,
                            Adres = "Besiktas",
                            YayinEviAdi = "Gama"
                        });
                });

            modelBuilder.Entity("BookShop_Hoca.Models.Kitap", b =>
                {
                    b.HasOne("BookShop_Hoca.Models.Yayinevi", "Yayinevi")
                        .WithMany("Kitaplar")
                        .HasForeignKey("YayinEviID");

                    b.Navigation("Yayinevi");
                });

            modelBuilder.Entity("BookShop_Hoca.Models.Yayinevi", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
