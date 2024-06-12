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
    public class Admin_CFG : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("ADMINS");

            builder.Property(x => x.AdminID)
                   .HasColumnName("ADMIN_ID");

            builder.Property(x => x.FirstName)
                   .HasColumnName("FIRST_NAME")
                   .HasMaxLength(50)
                   .IsRequired(true);

            builder.Property(x => x.LastName)
                   .HasColumnName("LAST_NAME")
                   .HasMaxLength(50)
                   .IsRequired(true);

            builder.Property(x => x.UserName)
                   .HasColumnName("USER_NAME")
                   .HasMaxLength(100)
                   .IsRequired(true);

            builder.Property(x => x.Password)
                   .HasColumnName("PASSWORD")
                   .HasMaxLength(150)
                   .IsRequired(true);

            builder.Property(x => x.PasswordConfirm)
                   .HasColumnName("PASSWORD_CONFIRM")
                   .HasMaxLength(150)
                   .IsRequired(true);
        }
    }
}
