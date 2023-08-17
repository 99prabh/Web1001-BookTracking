using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web1001_BookTracking.Models;

namespace Web1001_BookTracking.Data.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            // Configure your Book entity here
            builder.HasKey(b => b.ISBN);

            // Example: if you want to configure relationships
            builder.HasOne(b => b.Category)
                   .WithMany(c => c.Books)
                   .HasForeignKey(b => b.Category_NameToken)
                   .OnDelete(DeleteBehavior.Restrict); // Specify the desired behavior
        }
    }
}
