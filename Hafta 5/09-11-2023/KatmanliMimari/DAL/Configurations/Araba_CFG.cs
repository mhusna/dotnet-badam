using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class Araba_CFG : IEntityTypeConfiguration<Araba>
    {
        public void Configure(EntityTypeBuilder<Araba> builder)
        {
            builder.ToTable("ARABALAR");
            
            builder.Property(x => x.ArabaID)
                   .HasColumnName("ARABA_ID");

            builder.Property(x => x.Plaka)
                   .HasColumnName("PLAKA")
                   .HasColumnType("CHAR")
                   .HasMaxLength(8);

            builder.Property(x => x.Fiyat)
                   .HasColumnName("FIYAT");

            builder.Property(x => x.Resim)
                   .HasColumnName("RESIM");

            builder.Property(x => x.MarkaID)
                   .HasColumnName("MARKA_ID");

            builder.Property(x => x.ModelID)
                   .HasColumnName("MODEL_ID");
        }
    }
}
