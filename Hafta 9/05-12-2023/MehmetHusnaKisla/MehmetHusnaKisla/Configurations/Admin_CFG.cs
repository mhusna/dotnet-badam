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
                   .HasColumnName("ADMIN_ID")
                   .UseIdentityColumn(2, 1);

            builder.Property(x => x.UserName)
                   .HasColumnName("USER_NAME")
                   .HasMaxLength(50)
                   .IsRequired(true);

            builder.HasIndex(x => x.UserName)
                   .IsUnique();

            builder.Property(x => x.Password)
                   .HasColumnName("PASSWORD")
                   .HasMaxLength(150)
                   .IsRequired(true);

            builder.Property(x => x.PasswordConfirm)
                   .HasColumnName("PASSWORD_CONFIRM")
                   .HasMaxLength(150)
                   .IsRequired(true);

            builder.HasData(new Admin { AdminID = 1, UserName = "mhusna", Password = "123", PasswordConfirm = "123" });
        }
    }
}
