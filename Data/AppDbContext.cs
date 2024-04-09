using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Data
{
    // DbContext represents a session with the database and allows querying and saving data
    public class AppDbContext : DbContext
    {
        // DbSet properties represent database tables
        // Each DbSet corresponds to an entity (table) in the database
        public DbSet<Book> Books { get; set; }

        // Constructor to initialize the DbContext with options
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Override OnModelCreating to provide additional model configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Optional: Configure entity relationships, indexes, and other model aspects

            // Seed initial data into the database
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Book 1", Author = "Author 1", Copies = 10 },
                new Book { Id = 2, Title = "Book 2", Author = "Author 2", Copies = 5 },
                new Book { Id = 3, Title = "Book 3", Author = "Author 3", Copies = 8 }
            );
        }
    }
}