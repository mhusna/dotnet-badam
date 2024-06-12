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
    public class Haber_CFG : IEntityTypeConfiguration<Haber.Domain.Entities.Haber>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Haber> builder)
        {
            builder.ToTable("HABERLER");

            builder.Property(x => x.HaberID)
                   .HasColumnName("HABER_ID");

            builder.Property(x => x.Baslik)
                   .HasColumnName("BASLIK")
                   .IsRequired(true);

            builder.Property(x => x.Detay)
                   .HasColumnName("DETAY")
                   .IsRequired(true);

            builder.Property(x => x.ResimYolu)
                   .HasColumnName("RESIM_YOLU");

            builder.Property(x => x.GoruntulenmeSayisi)
                   .HasColumnName("GORUNTULENME_SAYISI");

            builder.Property(x => x.HaberEkleyenID)
                   .HasColumnName("HABER_EKLEYEN_ID");

            builder.Property(x => x.KategoriID)
                   .HasColumnName("KATEGORI_ID");

            builder.Property(x => x.EklemeTarihi)
                    .HasColumnName("EKLEME_TARIHI");

            builder.Property(x => x.GuncellemeTarihi)
                    .HasColumnName("GUNCELLEME_TARIHI");

            builder.Property(x => x.SilmeTarihi)
                    .HasColumnName("SILME_TARIHI");

            builder.Property(x => x.KayitDurumu)
                    .HasColumnName("KAYIT_DURUMU");
        }
    }
}
