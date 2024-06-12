using MehmetHusnaKisla.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Configurations
{
    public class Entity_CFG : IEntityTypeConfiguration<Entity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entity> builder)
        {
            builder.ToTable("");

            builder.Property(x => x.EntityID)
                   .HasColumnName("")
                   .UseIdentityColumn(1, 1)
                   .HasMaxLength(1);

            builder.HasData(
                new Entity { });
        }
    }
}
