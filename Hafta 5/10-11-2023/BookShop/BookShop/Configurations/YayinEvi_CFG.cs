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
    public class YayinEvi_CFG : IEntityTypeConfiguration<YayinEvi>
    {
        public void Configure(EntityTypeBuilder<YayinEvi> builder)
        {
            builder.ToTable("YAYINEVLERI");

            builder.Property(x => x.YayinEviID)
                   .HasColumnName("YAYINEVI_ID")
                   .UseIdentityColumn(3, 1);

            builder.Property(x => x.Ad)
                   .HasColumnName("YAYINEVI_ADI")
                   .HasMaxLength(50)
                   .IsRequired(true);

            builder.HasData(
                new YayinEvi { YayinEviID = 1, Ad = "Kültür Yayınevi"},
                new YayinEvi { YayinEviID = 2, Ad = "Zambak Yayınevi"});
        }
    }
}
