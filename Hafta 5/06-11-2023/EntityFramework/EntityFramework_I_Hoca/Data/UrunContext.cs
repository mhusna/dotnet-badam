using EntityFramework_I_Hoca.Configuration;
using EntityFramework_I_Hoca.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Hoca.Data
{
    public class UrunContext : DbContext
    {
        public UrunContext() { }

        public UrunContext(DbContextOptions<UrunContext> options) : base(options) { }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id = UrunDBHoca; Password = UrunDBHoca; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = orcl)))");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*
                YÖNTEM 2

            modelBuilder.Entity<Urun>()
                        .ToTable("URUNLER");

            modelBuilder.Entity<Urun>()
                        .Property(x => x.UrunID)
                        .HasColumnName("URUN_ID");

            modelBuilder.Entity<Urun>()
                        .Property(x => x.UrunAdi)
                        .HasColumnName("URUN_ADI");

            modelBuilder.Entity<Urun>()
                        .Property(x => x.Fiyat)
                        .HasColumnName("FIYAT");

            modelBuilder.Entity<Urun>()
                        .Property(x => x.KategoriID)
                        .HasColumnName("KATEGORI_ID");

            modelBuilder.Entity<Kategori>()
                        .ToTable("KATEGORILER");

            modelBuilder.Entity<Kategori>()
                        .Property(x => x.KategoriID)
                        .HasColumnName("KATEGORI_ID");

            modelBuilder.Entity<Kategori>()
                        .Property(x => x.KategoriAdi)
                        .HasColumnName("KATEGORI_ADI")
                        .HasColumnType("CHAR")
                        .HasMaxLength(30)
                        .IsRequired(true);

            modelBuilder.Entity<Kategori>()
                        .HasData(
                            new Kategori { KategoriID = 1, KategoriAdi = "Kırtasiye" },
                            new Kategori { KategoriID = 2, KategoriAdi = "Elektronik" },
                            new Kategori { KategoriID = 3, KategoriAdi = "Tekstil" }
                            );
            */

            modelBuilder.ApplyConfiguration(new Kategori_CFG());
            modelBuilder.ApplyConfiguration(new Urun_CFG());
        }
    }
}
