using BookShop_Hoca.Enums;
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
    public class Kitap_CFG : IEntityTypeConfiguration<Kitap>
    {
        public void Configure(EntityTypeBuilder<Kitap> builder)
        {
            builder.ToTable("KITAPLAR");

            builder.Property(x => x.KitapID)
                   .HasColumnName("KITAP_ID");

            builder.Property(x => x.KitapAdi)
                   .HasColumnName("KITAP_ADI")
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(x => x.StokAdedi)
                   .HasColumnName("STOK_ADEDI");

            builder.Property(x => x.Fiyat)
                   .HasColumnName("FIYAT");

            builder.Property(x => x.KitapDurumu)
                   .HasColumnName("KITAP_DURUMU")
                   .HasDefaultValue(KitapDurumu.Aktif)
                   .IsRequired();

            builder.Property(x => x.EklemeTarihi)
                   .HasColumnName("EKLEME_TARIHI")
                   .IsRequired();

            builder.Property(x => x.YayinEviID)
                   .HasColumnName("YAYINEVI_ID");
        }
    }
}
