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
    public class Category_CFG : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("CATEGORIES");

            builder.Property(x => x.CategoryID)
                   .UseIdentityColumn(4, 1);

            builder.Property(x => x.CategoryID)
                   .HasColumnName("CATEGORY_ID");

            builder.Property(x => x.CategoryName)
                   .HasColumnName("CATEGORY_NAME")
                   .HasColumnType("CHAR")
                   .HasMaxLength(30)
                   .IsRequired(true);

            builder.HasData(new Category { CategoryID = 1, CategoryName = "Kırtasiye"},
                            new Category { CategoryID = 2, CategoryName = "Elektronik"},
                            new Category { CategoryID = 3, CategoryName = "Tekstil"});
        }
    }
}
