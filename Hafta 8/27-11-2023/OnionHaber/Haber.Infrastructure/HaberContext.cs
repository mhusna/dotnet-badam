using Haber.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Haber.Domain.Entities;
using Haber.Infrastructure.EntityTypeConfigurations;
using Microsoft.AspNetCore.Identity;

namespace Haber.Infrastructure
{
    public class HaberContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public HaberContext() { }
        public HaberContext(DbContextOptions options) : base(options) { }

        public DbSet<Haber.Domain.Entities.Haber> Haberler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
        public DbSet<Favori> Favoriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseOracle("User Id = HaberDB; Password = HaberDB; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = oracl)))");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new Haber_CFG());
            builder.ApplyConfiguration(new Kategori_CFG());
            builder.ApplyConfiguration(new Yorum_CFG());
            builder.ApplyConfiguration(new Favori_CFG());
            builder.ApplyConfiguration(new AppRole_CFG());
            builder.ApplyConfiguration(new AppUser_CFG());

            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int>{ UserId = 1, RoleId = 1 });

        }
    }
}
