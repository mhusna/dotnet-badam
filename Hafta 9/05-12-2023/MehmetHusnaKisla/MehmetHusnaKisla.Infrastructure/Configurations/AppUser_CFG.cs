using MehmetHusnaKisla.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Infrastructure.Configurations
{
    public class AppUser_CFG : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Id)
                   .UseIdentityColumn(2, 1);

            builder.Property(x => x.FirstName)
                   .HasColumnName("FIRST_NAME");

            builder.Property(x => x.LastName)
                   .HasColumnName("LAST_NAME");

            AppUser superUser = new AppUser
            {
                Id = 1,
                FirstName = "Cevdet",
                LastName = "Korkmaz",
                Email = "cevdet@deneme.com",
                UserName = "Cevdo",
                NormalizedUserName = "CEVDO",
                NormalizedEmail = "CEVDET@DENEME.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                TwoFactorEnabled = false,
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            PasswordHasher<AppUser> hasher = new PasswordHasher<AppUser>();
            superUser.PasswordHash = hasher.HashPassword(superUser, "Cevdo_123");

            builder.HasData(superUser);
        }
    }
}
