using EntityFramework_I.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I.Data
{
    public class PersonelContext : DbContext
    {
        public PersonelContext() { }

        public PersonelContext(DbContextOptions<PersonelContext> options) : base(options) { }

        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Proje> Projeler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id = Personel; Password = Personel; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = orcl)))");
        }
    }
}
