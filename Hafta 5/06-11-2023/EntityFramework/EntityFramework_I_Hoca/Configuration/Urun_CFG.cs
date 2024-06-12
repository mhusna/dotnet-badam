using EntityFramework_I_Hoca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Hoca.Configuration
{
    public class Urun_CFG : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.ToTable("URUNLER");

            builder.Property(x => x.UrunID)
                   .HasColumnName("URUN_ID");

            builder.Property(x => x.UrunAdi)
                   .HasColumnName("URUN_ADI");

            builder.Property(x => x.Fiyat)
                   .HasColumnName("FIYAT");

            builder.Property(x => x.KategoriID)
                   .HasColumnName("KATEGORI_ID");
        }
    }
}
