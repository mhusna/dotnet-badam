using Haber.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Infrastructure.EntityTypeConfigurations
{
    public class Kategori_CFG : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.ToTable("KATEGORILER");

            builder.Property(x => x.KategoriID)
                   .HasColumnName("KATEGORI_ID")
                   .UseIdentityColumn(5, 1);

            builder.Property(x => x.KategoriAdi)
                   .HasColumnName("KATEGORI_ADI");

            builder.Property(x => x.EklemeTarihi)
                    .HasColumnName("EKLEME_TARIHI");

            builder.Property(x => x.GuncellemeTarihi)
                    .HasColumnName("GUNCELLEME_TARIHI");

            builder.Property(x => x.SilmeTarihi)
                    .HasColumnName("SILME_TARIHI");

            builder.Property(x => x.KayitDurumu)
                    .HasColumnName("KAYIT_DURUMU");

            builder.HasData(
                new Kategori { KategoriID = 1, KategoriAdi = "Ekonomi"},
                new Kategori { KategoriID = 2, KategoriAdi = "Teknoloji" },
                new Kategori { KategoriID = 3, KategoriAdi = "Spor"},
                new Kategori { KategoriID = 4, KategoriAdi = "Magazin"}
                );
        }
    }
}
