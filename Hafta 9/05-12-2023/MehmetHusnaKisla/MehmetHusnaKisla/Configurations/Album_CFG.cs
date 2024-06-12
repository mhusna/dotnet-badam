using MehmetHusnaKisla.Enums;
using MehmetHusnaKisla.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Configurations
{
    public class Album_CFG : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("ALBUMS");

            builder.Property(x => x.AlbumID)
                   .HasColumnName("ALBUM_ID");

            builder.Property(x => x.AlbumName)
                   .HasColumnName("ALBUM_NAME")
                   .HasMaxLength(100)
                   .IsRequired(true);

            builder.Property(x => x.PublishTime)
                   .HasColumnName("PUBLISH_TIME")
                   .IsRequired(true);

            builder.Property(x => x.Price)
                   .HasColumnName("PRICE")
                   .IsRequired(true);

            builder.Property(x => x.Discount)
                   .HasColumnName("DISCOUNT");

            builder.Property(x => x.IsOnSale)
                   .HasColumnName("IS_ON_SALE");

            builder.Property(x => x.InsertTime)
                   .HasColumnName("INSERT_TIME");

            builder.Property(x => x.ArtistID)
                   .HasColumnName("ARTIST_ID");
        }
    }
}
