﻿// <auto-generated />
using EntityFramework_I.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace EntityFramework_I.Migrations
{
    [DbContext(typeof(PersonelContext))]
    [Migration("20231103065438_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityFramework_I.Models.Bolum", b =>
                {
                    b.Property<int>("BolumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("BOLUM_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BolumID"), 1L, 1);

                    b.Property<string>("BolumAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("CHAR(100)")
                        .HasColumnName("BOLUMADI");

                    b.HasKey("BolumID");

                    b.ToTable("BOLUMLER");
                });

            modelBuilder.Entity("EntityFramework_I.Models.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("PERSONEL_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("BolumID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("ProjeID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("PersonelID");

                    b.HasIndex("BolumID");

                    b.HasIndex("ProjeID");

                    b.ToTable("PERSONELLER");
                });

            modelBuilder.Entity("EntityFramework_I.Models.Proje", b =>
                {
                    b.Property<int>("ProjeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjeID"), 1L, 1);

                    b.Property<string>("ProjeAdi")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("CHAR(150)")
                        .HasColumnName("PROJEADI");

                    b.HasKey("ProjeID");

                    b.ToTable("PROJELER");
                });

            modelBuilder.Entity("EntityFramework_I.Models.Personel", b =>
                {
                    b.HasOne("EntityFramework_I.Models.Bolum", "Bolum")
                        .WithMany("Personeller")
                        .HasForeignKey("BolumID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFramework_I.Models.Proje", "Proje")
                        .WithMany("Personeller")
                        .HasForeignKey("ProjeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bolum");

                    b.Navigation("Proje");
                });

            modelBuilder.Entity("EntityFramework_I.Models.Bolum", b =>
                {
                    b.Navigation("Personeller");
                });

            modelBuilder.Entity("EntityFramework_I.Models.Proje", b =>
                {
                    b.Navigation("Personeller");
                });
#pragma warning restore 612, 618
        }
    }
}
