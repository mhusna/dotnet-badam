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
    public class Kategori_CFG : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.ToTable("KATEGORILER");

            // İlk başta 3 tane kategori ekledik, normalde kullanıcının eklediğini 1'den başlatır.
            // Ama biz bundan sonra kullanıcının ekledikleri 4'den başlasın ve bir artarak devam etsin dedik.
            builder.Property(x => x.KategoriID).UseIdentityColumn(4, 1);

            builder.Property(x => x.KategoriID)
                   .HasColumnName("KATEGORI_ID");

            builder.Property(x => x.KategoriAdi)
                   .HasColumnName("KATEGORI_ADI")
                   .HasColumnType("CHAR")
                   .HasMaxLength(30)
                   .IsRequired(true);

            builder.HasData
                    (
                        new Kategori { KategoriID = 1, KategoriAdi = "Kirtasiye" },
                        new Kategori { KategoriID = 2, KategoriAdi = "Elektronik" },
                        new Kategori { KategoriID = 3, KategoriAdi = "Tekstil" }
                    );
        }
    }
}
