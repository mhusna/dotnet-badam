using MehmetHusnaKisla.Domain.Entities;
using MehmetHusnaKisla.Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Infrastructure
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        public Context() { }

        public Context(DbContextOptions options) : base(options) { }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Essay> Essays { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id = BlogDB; Password = BlogDB; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = orcl)))");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AppRole_CFG());
            builder.ApplyConfiguration(new AppUser_CFG());
            builder.ApplyConfiguration(new Topic_CFG());
            builder.ApplyConfiguration(new Essay_CFG());

            builder.Entity<IdentityUserRole<int>>().HasData( new IdentityUserRole<int> { UserId = 1, RoleId = 1 } );
        }
    }
}
