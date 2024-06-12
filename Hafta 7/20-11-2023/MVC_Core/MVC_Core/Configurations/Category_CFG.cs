using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Core.Models;

namespace MVC_Core.Configurations
{
    public class Category_CFG : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("CATEGORIES");

            builder.Property(x => x.CategoryID).HasColumnName("CATEGORY_ID");
            builder.Property(x => x.Name).HasColumnName("NAME");
        }
    }
}
