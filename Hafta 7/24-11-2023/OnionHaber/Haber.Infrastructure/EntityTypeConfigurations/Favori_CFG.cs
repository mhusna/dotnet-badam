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
    public class Favori_CFG : IEntityTypeConfiguration<Favori>
    {
        public void Configure(EntityTypeBuilder<Favori> builder)
        {
            builder.ToTable("FAVORILER");

            builder.Property(x => x.FavoriID)
                   .HasColumnName("FAVORI_ID");

            builder.Property(x => x.HaberID)
                   .HasColumnName("HABER_ID");

            builder.Property(x => x.UserID)
                   .HasColumnName("USER_ID");

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
