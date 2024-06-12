﻿using BookShop_Hoca.Configurations;
using BookShop_Hoca.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Hoca.Data
{
    public class KitapContext : DbContext
    {
        public KitapContext() { }

        public KitapContext(DbContextOptions<KitapContext> options) : base(options)
        {

        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yayinevi> Yayinevleri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id = BookShopDBHoca; Password = BookShopDBHoca; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = orcl)))");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new Kullanici_CFG());
            modelBuilder.ApplyConfiguration(new Kitap_CFG());
            modelBuilder.ApplyConfiguration(new Yayinevi_CFG());
        }
    }
}
