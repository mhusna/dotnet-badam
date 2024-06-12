using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Core.Models;

namespace MVC_Core.Configurations
{
    public class Brand_CFG : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("BRANDS");

            builder.Property(x => x.BrandID).HasColumnName("BRAND_ID");
            builder.Property(x => x.Name).HasColumnName("NAME");
        }
    }
}
