using E_Com.Core.Entities.Product;
using Microsoft.EntityFrameworkCore;


namespace E_Com.Infrastructure.Database.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>

    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
           builder.Property(x => x.Name).IsRequired().HasMaxLength(75).IsRequired();
           builder.Property(x => x.Description).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Price).HasPrecision(18, 2).IsRequired();
        }
    }
}
