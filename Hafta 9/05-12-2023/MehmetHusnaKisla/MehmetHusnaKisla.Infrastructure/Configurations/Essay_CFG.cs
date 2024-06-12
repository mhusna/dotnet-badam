using MehmetHusnaKisla.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Infrastructure.Configurations
{
    public class Essay_CFG : IEntityTypeConfiguration<Essay>
    {
        public void Configure(EntityTypeBuilder<Essay> builder)
        {
            builder.ToTable("ESSAYS");

            builder.Property(x => x.EssayID)
                   .HasColumnName("ESSAY_ID");

            builder.Property(x => x.EssayName)
                   .HasColumnName("ESSAY_NAME")
                   .HasMaxLength(100)
                   .IsRequired(true);

            builder.Property(x => x.EssayContent)
                   .HasColumnName("ESSAY_CONTENT")
                   .HasMaxLength(1000)
                   .IsRequired(true);

            builder.Property(x => x.PublisherID)
                   .HasColumnName("PUBLISHER_ID");

            builder.Property(x => x.TopicID)
                   .HasColumnName("TOPIC_ID");

            builder.Property(x => x.InsertDate)
                   .HasColumnName("INSERT_DATE");

            builder.Property(x => x.DeleteDate)
                   .HasColumnName("DELETE_DATE");

            builder.Property(x => x.UpdateDate)
                   .HasColumnName("UPDATE_DATE");

            builder.Property(x => x.RecordStatus)
                   .HasColumnName("RECORD_STATUS");
        }
    }
}
