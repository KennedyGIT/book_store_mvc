using bookstore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bookstore.DataAccess.Data
{
    public class BookStoreDBContext : IdentityDbContext<IdentityUser>
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers {get; set;}
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);

           modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Adventure", DisplayOrder = 1},
               new Category { Id = 2, Name = "Fantasy", DisplayOrder = 2 },
               new Category { Id = 3, Name = "SciFi", DisplayOrder = 3 },
               new Category { Id = 4, Name = "Thriller", DisplayOrder = 4 }
               );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Great Gatsby",
                    Description = "A novel by F. Scott Fitzgerald",
                    ISBN = "978-0743273565",
                    Author = "F. Scott Fitzgerald",
                    ListPrice = 14.99,
                    Price = 12.99,
                    Price50 = 11.99,
                    Price100 = 10.99,
                    CategoryId = 2,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Title = "To Kill a Mockingbird",
                    Description = "A novel by Harper Lee",
                    ISBN = "978-0061120084",
                    Author = "Harper Lee",
                    ListPrice = 16.99,
                    Price = 13.99,
                    Price50 = 12.99,
                    Price100 = 11.99,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "1984",
                    Description = "A novel by George Orwell",
                    ISBN = "978-0452284234",
                    Author = "George Orwell",
                    ListPrice = 12.99,
                    Price = 10.99,
                    Price50 = 9.99,
                    Price100 = 8.99,
                    CategoryId = 4,
                    ImageUrl = ""

                },
                new Product
                {
                    Id = 4,
                    Title = "Pride and Prejudice",
                    Description = "A novel by Jane Austen",
                    ISBN = "978-0486284736",
                    Author = "Jane Austen",
                    ListPrice = 10.99,
                    Price = 8.99,
                    Price50 = 7.99,
                    Price100 = 6.99,
                    CategoryId = 3,
                    ImageUrl = ""



                },
                new Product
                {
                    Id = 5,
                    Title = "The Catcher in the Rye",
                    Description = "A novel by J.D. Salinger",
                    ISBN = "978-0316769488",
                    Author = "J.D. Salinger",
                    ListPrice = 15.99,
                    Price = 12.99,
                    Price50 = 11.99,
                    Price100 = 10.99,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "Lord of the Flies",
                    Description = "A novel by William Golding",
                    ISBN = "978-0399501487",
                    Author = "William Golding",
                    ListPrice = 13.99,
                    Price = 11.99,
                    Price50 = 10.99,
                    Price100 = 9.99,
                    CategoryId = 1,
                    ImageUrl = ""

                },
                new Product
                {
                    Id = 7,
                    Title = "The Hobbit",
                    Description = "A novel by J.R.R. Tolkien",
                    ISBN = "978-0547928227",
                    Author = "J.R.R. Tolkien",
                    ListPrice = 18.99,
                    Price = 15.99,
                    Price50 = 14.99,
                    Price100 = 13.99,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 8,
                    Title = "Moby-Dick",
                    Description = "A novel by Herman Melville",
                    ISBN = "978-0142437247",
                    Author = "Herman Melville",
                    ListPrice = 17.99,
                    Price = 14.99,
                    Price50 = 13.99,
                    Price100 = 12.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 9,
                    Title = "The Picture of Dorian Gray",
                    Description = "A novel by Oscar Wilde",
                    ISBN = "978-1503299643",
                    Author = "Oscar Wilde",
                    ListPrice = 11.99,
                    Price = 9.99,
                    Price50 = 8.99,
                    Price100 = 7.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 10,
                    Title = "Frankenstein",
                    Description = "A novel by Mary Shelley",
                    ISBN = "978-0486282114",
                    Author = "Mary Shelley",
                    ListPrice = 14.99,
                    Price = 11.99,
                    Price50 = 10.99,
                    Price100 = 9.99,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 11,
                    Title = "Brave New World",
                    Description = "A novel by Aldous Huxley",
                    ISBN = "978-0060850524",
                    Author = "Aldous Huxley",
                    ListPrice = 16.99,
                    Price = 13.99,
                    Price50 = 12.99,
                    Price100 = 11.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 12,
                    Title = "The Adventures of Tom Sawyer",
                    Description = "A novel by Mark Twain",
                    ISBN = "978-0486400778",
                    Author = "Mark Twain",
                    ListPrice = 12.99,
                    Price = 10.99,
                    Price50 = 9.99,
                    Price100 = 8.99,
                    CategoryId = 3,
                    ImageUrl = ""

                },
                new Product
                {
                    Id = 13,
                    Title = "Dracula",
                    Description = "A novel by Bram Stoker",
                    ISBN = "978-0486411095",
                    Author = "Bram Stoker",
                    ListPrice = 13.99,
                    Price = 11.99,
                    Price50 = 10.99,
                    Price100 = 9.99,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 14,
                    Title = "The Count of Monte Cristo",
                    Description = "A novel by Alexandre Dumas",
                    ISBN = "978-0141392462",
                    Author = "Alexandre Dumas",
                    ListPrice = 19.99,
                    Price = 16.99,
                    Price50 = 15.99,
                    Price100 = 14.99,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 15,
                    Title = "The Scarlet Letter",
                    Description = "A novel by Nathaniel Hawthorne",
                    ISBN = "978-0142423356",
                    Author = "Nathaniel Hawthorne",
                    ListPrice = 15.99,
                    Price = 12.99,
                    Price50 = 11.99,
                    Price100 = 10.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 16,
                    Title = "Alice's Adventures in Wonderland",
                    Description = "A novel by Lewis Carroll",
                    ISBN = "978-0486275437",
                    Author = "Lewis Carroll",
                    ListPrice = 10.99,
                    Price = 8.99,
                    Price50 = 7.99,
                    Price100 = 6.99,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 18,
                    Title = "Wuthering Heights",
                    Description = "A novel by Emily Brontë",
                    ISBN = "978-0141439556",
                    Author = "Emily Brontë",
                    ListPrice = 14.99,
                    Price = 11.99,
                    Price50 = 10.99,
                    Price100 = 9.99,
                    CategoryId = 2,
                    ImageUrl = ""
                }
                );
                
        }
    }
}
