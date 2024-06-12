﻿// <auto-generated />
using System;
using MehmetHusnaKisla.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace MehmetHusnaKisla.Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231205064920_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MehmetHusnaKisla.Domain.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 3L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("\"NormalizedName\" IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "ec5652b3-e04b-4fd6-856a-12f0f81bfab5",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "16719bd4-665f-4ed3-bec1-535873479499",
                            Name = "Uye",
                            NormalizedName = "UYE"
                        });
                });

            modelBuilder.Entity("MehmetHusnaKisla.Domain.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 2L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("FIRST_NAME");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("LAST_NAME");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("NUMBER(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("\"NormalizedUserName\" IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "55f14589-dd49-4167-971d-c41411b93525",
                            Email = "cevdet@deneme.com",
                            EmailConfirmed = false,
                            FirstName = "Cevdet",
                            LastName = "Korkmaz",
                            LockoutEnabled = false,
                            NormalizedEmail = "CEVDET@DENEME.COM",
                            NormalizedUserName = "CEVDO",
                            PasswordHash = "AQAAAAEAACcQAAAAEGOQ8SHXHzZRSC52Rh29CwL/vhTHm9ktpC7f0GSQETxvJYw4A+xfQyb6ndHn3DkzuA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6be735f0-27dd-4361-8bc8-28a6470fc016",
                            TwoFactorEnabled = false,
                            UserName = "Cevdo"
                        });
                });

            modelBuilder.Entity("MehmetHusnaKisla.Domain.Entities.Essay", b =>
                {
                    b.Property<int>("EssayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ESSAY_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EssayID"), 1L, 1);

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DELETE_DATE");

                    b.Property<string>("EssayContent")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("NVARCHAR2(1000)")
                        .HasColumnName("ESSAY_CONTENT");

                    b.Property<string>("EssayName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("ESSAY_NAME");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("INSERT_DATE");

                    b.Property<int>("PublisherID")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("PUBLISHER_ID");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("RECORD_STATUS");

                    b.Property<int>("TopicID")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("TOPIC_ID");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("UPDATE_DATE");

                    b.HasKey("EssayID");

                    b.HasIndex("PublisherID");

                    b.HasIndex("TopicID");

                    b.ToTable("ESSAYS", (string)null);
                });

            modelBuilder.Entity("MehmetHusnaKisla.Domain.Entities.Topic", b =>
                {
                    b.Property<int>("TopicID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("TOPIC_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TopicID"), 1L, 1);

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DELETE_DATE");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("INSERT_DATE");

                    b.Property<int>("InserterID")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("INSERTER_ID");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("RECORD_STATUS");

                    b.Property<string>("TopicName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("TOPIC_NAME");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("UPDATE_DATE");

                    b.HasKey("TopicID");

                    b.HasIndex("InserterID");

                    b.ToTable("TOPICS", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("RoleId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("UserId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("UserId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("RoleId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Value")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MehmetHusnaKisla.Domain.Entities.Essay", b =>
                {
                    b.HasOne("MehmetHusnaKisla.Domain.Entities.AppUser", "Publisher")
                        .WithMany("Essays")
                        .HasForeignKey("PublisherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MehmetHusnaKisla.Domain.Entities.Topic", "Topic")
                        .WithMany("Essays")
                        .HasForeignKey("TopicID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("MehmetHusnaKisla.Domain.Entities.Topic", b =>
                {
                    b.HasOne("MehmetHusnaKisla.Domain.Entities.AppUser", "User")
                        .WithMany("Topics")
                        .HasForeignKey("InserterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("MehmetHusnaKisla.Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("MehmetHusnaKisla.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("MehmetHusnaKisla.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("MehmetHusnaKisla.Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MehmetHusnaKisla.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("MehmetHusnaKisla.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MehmetHusnaKisla.Domain.Entities.AppUser", b =>
                {
                    b.Navigation("Essays");

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("MehmetHusnaKisla.Domain.Entities.Topic", b =>
                {
                    b.Navigation("Essays");
                });
#pragma warning restore 612, 618
        }
    }
}