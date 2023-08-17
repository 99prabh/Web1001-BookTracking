using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web1001_BookTracking.Models;

namespace Web1001_BookTracking.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Configure your Category entity here
            builder.HasKey(c => c.NameToken);

            // Example: if you want to configure relationships
            builder.HasOne(c => c.CategoryTypeEntity)
                   .WithMany(ct => ct.Categories)
                   .HasForeignKey(c => c.CategoryType);
        }
    }
}
