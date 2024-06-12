using BookShop_Hoca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Hoca.Configurations
{
    public class Kullanici_CFG : IEntityTypeConfiguration<Kullanici>
    {

        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.ToTable("KULLANICILAR");

            builder.Property(x => x.KullaniciID)
                   .HasColumnName("KULLANICI_ID")
                   .UseIdentityColumn(2, 1);

            builder.Property(x => x.Ad)
                   .HasColumnName("AD")
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(x => x.Soyad)
                   .HasColumnName("SOYAD")
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(x => x.Sifre)
                   .HasColumnName("SIFRE")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasData(
                new Kullanici
                {
                    KullaniciID = 1,
                    Ad = "Cevdet",
                    Soyad = "Korkmaz",
                    KullaniciAdi = "cevdo",
                    Sifre = Utilities.Utility.SifreMD5("cev_123")
                });

        }
    }
}
