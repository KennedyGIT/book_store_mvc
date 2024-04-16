using book_store.Models;
using Microsoft.EntityFrameworkCore;

namespace book_store.Data
{
    public class BookStoreDBContext : DbContext
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options) : base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Adventure", DisplayOrder = 1},
               new Category { Id = 2, Name = "Fantasy", DisplayOrder = 2 },
               new Category { Id = 3, Name = "SciFi", DisplayOrder = 3 },
               new Category { Id = 4, Name = "Thriller", DisplayOrder = 4 }
               );
        }
    }
}
