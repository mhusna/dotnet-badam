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
    public class Topic_CFG : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.ToTable("TOPICS");

            builder.Property(x => x.TopicID)
                   .HasColumnName("TOPIC_ID");

            builder.Property(x => x.TopicName)
                   .HasColumnName("TOPIC_NAME")
                   .HasMaxLength(50)
                   .IsRequired(true);

            builder.Property(x => x.InserterID)
                   .HasColumnName("INSERTER_ID");

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
