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
        // Eğer default ctor olmazsa hata verir.
        public PersonelContext()
        {
        }

        // Burası Dependency Injection ve IoC ile alakalı.
        public PersonelContext(DbContextOptions<PersonelContext> options) : base(options)
        {
        }

        public DbSet<Personel> PERSONELLER { get; set; }
        public DbSet<Bolum> BOLUMLER { get; set; }
        public DbSet<Proje> PROJELER { get; set; }
        public DbSet<PersonelProje> PERSONELPROJELERI { get; set; }
        public DbSet<PersonelDetay> PERSONELDETAYLARI { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id = TestDB; Password = TestDB; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = oracl)))");
        }
    }
}
