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
    public class Admin_CFG : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("ADMINLER");

            builder.Property(x => x.AdminID)
                   .HasColumnName("ADMIN_ID")
                   .UseIdentityColumn(2, 1);

            builder.Property(x => x.Ad)
                   .HasColumnName("ADMIN_AD")
                   .HasMaxLength(30);

            builder.Property(x => x.Soyad)
                   .HasColumnName("ADMIN_SOYAD")
                   .HasMaxLength(30);

            builder.Property(x => x.MailAdresi)
                   .HasColumnName("MAIL_ADRESI")
                   .HasMaxLength(50)
                   .IsRequired(true);

            builder.Property(x => x.Sifre)
                   .HasColumnName("SIFRE")
                   .HasMaxLength(150)
                   .IsRequired(true);

            builder.HasData(
                new Admin { 
                    AdminID = 1, 
                    Ad = "Mehmet", 
                    Soyad = "Kisla", 
                    MailAdresi = "admin@gmail.com", 
                    Sifre = "admin" 
                });
        }
    }
}
