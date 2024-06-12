﻿// <auto-generated />
using EntityFramework_I_Hoca.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace EntityFramework_I_Hoca.Migrations
{
    [DbContext(typeof(UrunContext))]
    partial class UrunContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityFramework_I_Hoca.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("KATEGORI_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriID"), 4L, 1);

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("CHAR(30)")
                        .HasColumnName("KATEGORI_ADI");

                    b.HasKey("KategoriID");

                    b.ToTable("KATEGORILER", (string)null);

                    b.HasData(
                        new
                        {
                            KategoriID = 1,
                            KategoriAdi = "Kırtasiye"
                        },
                        new
                        {
                            KategoriID = 2,
                            KategoriAdi = "Elektronik"
                        },
                        new
                        {
                            KategoriID = 3,
                            KategoriAdi = "Tekstil"
                        });
                });

            modelBuilder.Entity("EntityFramework_I_Hoca.Models.Urun", b =>
                {
                    b.Property<int>("UrunID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("URUN_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UrunID"), 1L, 1);

                    b.Property<double>("Fiyat")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("FIYAT");

                    b.Property<int>("KategoriID")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("KATEGORI_ID");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("URUN_ADI");

                    b.HasKey("UrunID");

                    b.HasIndex("KategoriID");

                    b.ToTable("URUNLER", (string)null);
                });

            modelBuilder.Entity("EntityFramework_I_Hoca.Models.Urun", b =>
                {
                    b.HasOne("EntityFramework_I_Hoca.Models.Kategori", "Kategori")
                        .WithMany("Urunler")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("EntityFramework_I_Hoca.Models.Kategori", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}