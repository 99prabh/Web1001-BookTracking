using Microsoft.EntityFrameworkCore;
using Web1001_BookTracking.Models;
using Web1001_BookTracking.Data.Config;
namespace Web1001_BookTracking // Replace with your actual namespace
{
    public class BookTrackingDbContext : DbContext
    {
        public BookTrackingDbContext(DbContextOptions<BookTrackingDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryType> CategoryTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply configurations
            modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new CategoryTypeConfig());

            // Additional configuration if needed
        }

    }
}
