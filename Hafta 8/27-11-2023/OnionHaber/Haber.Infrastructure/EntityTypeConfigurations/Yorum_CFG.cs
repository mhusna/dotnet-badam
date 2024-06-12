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
    public class Yorum_CFG : IEntityTypeConfiguration<Yorum>
    {
        public void Configure(EntityTypeBuilder<Yorum> builder)
        {
            builder.ToTable("YORUMLAR");

            builder.Property(x => x.YorumID)
                   .HasColumnName("YORUM_ID");

            builder.Property(x => x.YorumIcerik)
                   .HasColumnName("YORUM_ICERIK")
                   .HasMaxLength(300)
                   .IsRequired(true);

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
