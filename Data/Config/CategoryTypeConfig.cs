using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web1001_BookTracking.Models;

namespace Web1001_BookTracking.Data.Config
{
    public class CategoryTypeConfig : IEntityTypeConfiguration<CategoryType>
    {
        public void Configure(EntityTypeBuilder<CategoryType> builder)
        {
            // Configure your CategoryType entity here
            builder.HasKey(ct => ct.Type);

            // Example: if you want to configure relationships
            builder.HasMany(ct => ct.Categories)
                   .WithOne(c => c.CategoryTypeEntity)
                   .HasForeignKey(c => c.CategoryType);
        }
    }
}
