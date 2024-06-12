using BookShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Configurations
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
                   .IsRequired(true)
                   .HasMaxLength(40);
             
            builder.Property(x => x.SatisDurum)
                   .HasColumnName("SATIS_DURUM");

            builder.Property(x => x.Fiyat)
                   .HasColumnName("FIYAT");

            builder.Property(x => x.YayinEviID)
                   .HasColumnName("YAYINEVI_ID");
        }
    }
}
