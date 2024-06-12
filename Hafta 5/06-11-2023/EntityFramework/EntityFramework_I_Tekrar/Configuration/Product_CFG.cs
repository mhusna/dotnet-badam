using EntityFramework_I_Tekrar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Tekrar.Configuration
{
    public class Product_CFG : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUCTS");

            builder.Property(x => x.ProductID)
                   .HasColumnName("PRODUCT_ID");

            builder.Property(x => x.ProductName)
                   .HasColumnName("PRODUCT_NAME");

            builder.Property(x => x.ProductPrice)
                   .HasColumnName("PRODUCT_PRICE");

            builder.Property(x => x.CategoryID)
                   .HasColumnName("CATEGORY_ID");
        }
    }
}
