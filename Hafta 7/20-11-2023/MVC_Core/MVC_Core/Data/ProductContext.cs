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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Product_CFG());
            modelBuilder.ApplyConfiguration(new Brand_CFG());
            modelBuilder.ApplyConfiguration(new Category_CFG());
        }
    }
}
