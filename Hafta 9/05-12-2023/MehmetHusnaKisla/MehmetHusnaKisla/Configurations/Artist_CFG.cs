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
    public class Artist_CFG : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("ARTISTS");

            builder.Property(x => x.ArtistID)
                   .HasColumnName("ARTIST_ID");

            builder.Property(x => x.ArtistName)
                   .HasColumnName("ARTIST_NAME")
                   .HasMaxLength(50)
                   .IsRequired(true);

            builder.Property(x => x.IsDeleted)
                   .HasColumnName("IS_DELETED")
                   .HasDefaultValue(IsDeleted.Active);
        }
    }
}
