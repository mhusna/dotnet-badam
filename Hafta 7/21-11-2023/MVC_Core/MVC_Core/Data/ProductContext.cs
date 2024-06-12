using Microsoft.EntityFrameworkCore;
using MVC_Core.Configurations;
using MVC_Core.Models;

namespace MVC_Core.Data
{
    public class ProductContext : DbContext
    {
        //public ProductContext() { }
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id = ProductDB; Password = ProductDB; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = orcl)))");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Product_CFG());
            modelBuilder.ApplyConfiguration(new Brand_CFG());
            modelBuilder.ApplyConfiguration(new Category_CFG());
        }
    }
}
