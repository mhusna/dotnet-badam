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
    public class Yayinevi_CFG : IEntityTypeConfiguration<Yayinevi>
    {
        public void Configure(EntityTypeBuilder<Yayinevi> builder)
        {

            builder.ToTable("YAYINEVLERI");

            builder.Property(x => x.YayinEviID)
                   .HasColumnName("YAYINEVI_ID")
                   .UseIdentityColumn(4, 1);

            builder.Property(x => x.YayinEviAdi)
                   .HasColumnName("YAYINEVI_ADI")
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(x => x.Adres)
                   .HasColumnName("ADRES");

            builder.HasData(
                new Yayinevi { YayinEviID = 1, YayinEviAdi = "Alfa", Adres = "Kadıköy"},
                new Yayinevi { YayinEviID = 2, YayinEviAdi = "Is Bankasi Yayinlari", Adres = "Sisli"},
                new Yayinevi { YayinEviID = 3, YayinEviAdi = "Gama", Adres = "Besiktas"}
                );
        }
    }
}
