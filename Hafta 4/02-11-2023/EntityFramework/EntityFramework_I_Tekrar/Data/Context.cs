using EntityFramework_I_Tekrar.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Tekrar.Data
{
    public class Context : DbContext
    {
        // Default ctor yazmazsak hata veriyor.
        public Context() { }

        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Personel> PERSONELLER { get; set; }
        public DbSet<Bolum> BOLUMLER  { get; set; }
        public DbSet<Proje> PROJELER { get; set; }
        public DbSet<PersonelProje> PERSONELPROJELERI { get; set; }
        public DbSet<PersonelDetay> PERSONELDETAYLAR { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id = TestDB; Password = TestDB; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = oracl)))");
        }
    }
}
