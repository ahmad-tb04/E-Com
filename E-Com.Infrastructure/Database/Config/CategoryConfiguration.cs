using E_Com.Core.Entities.Product;
using Microsoft.EntityFrameworkCore;


namespace E_Com.Infrastructure.Database.Config
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

        }
    }
}
