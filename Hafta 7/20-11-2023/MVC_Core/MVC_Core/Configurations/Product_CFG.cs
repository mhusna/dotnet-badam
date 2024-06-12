using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Core.Models;

namespace MVC_Core.Configurations
{
    public class Product_CFG : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUCTS");

            builder.Property(x => x.ProductID).HasColumnName("PRODUCT_ID");
            builder.Property(x => x.Name).HasColumnName("NAME");
            builder.Property(x => x.Price).HasColumnName("PRICE");
            builder.Property(x => x.Description).HasColumnName("DESCRIPTION");
            builder.Property(x => x.Description).HasColumnName("IMAGEPATH");
            builder.Property(x => x.BrandID).HasColumnName("BRAND_ID");
            builder.Property(x => x.CategoryID).HasColumnName("CATEGORY_ID");
        }
    }
}
