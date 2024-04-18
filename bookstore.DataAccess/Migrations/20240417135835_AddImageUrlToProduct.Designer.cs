﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bookstore.DataAccess.Data;

#nullable disable

namespace bookstore.DataAccess.Migrations
{
    [DbContext(typeof(BookStoreDBContext))]
    [Migration("20240417135835_AddImageUrlToProduct")]
    partial class AddImageUrlToProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("bookstore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Thriller"
                        });
                });

            modelBuilder.Entity("bookstore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "F. Scott Fitzgerald",
                            CategoryId = 2,
                            Description = "A novel by F. Scott Fitzgerald",
                            ISBN = "978-0743273565",
                            ImageUrl = "",
                            ListPrice = 14.99,
                            Price = 12.99,
                            Price100 = 10.99,
                            Price50 = 11.99,
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Harper Lee",
                            CategoryId = 3,
                            Description = "A novel by Harper Lee",
                            ISBN = "978-0061120084",
                            ImageUrl = "",
                            ListPrice = 16.989999999999998,
                            Price = 13.99,
                            Price100 = 11.99,
                            Price50 = 12.99,
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            Id = 3,
                            Author = "George Orwell",
                            CategoryId = 4,
                            Description = "A novel by George Orwell",
                            ISBN = "978-0452284234",
                            ImageUrl = "",
                            ListPrice = 12.99,
                            Price = 10.99,
                            Price100 = 8.9900000000000002,
                            Price50 = 9.9900000000000002,
                            Title = "1984"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Jane Austen",
                            CategoryId = 3,
                            Description = "A novel by Jane Austen",
                            ISBN = "978-0486284736",
                            ImageUrl = "",
                            ListPrice = 10.99,
                            Price = 8.9900000000000002,
                            Price100 = 6.9900000000000002,
                            Price50 = 7.9900000000000002,
                            Title = "Pride and Prejudice"
                        },
                        new
                        {
                            Id = 5,
                            Author = "J.D. Salinger",
                            CategoryId = 2,
                            Description = "A novel by J.D. Salinger",
                            ISBN = "978-0316769488",
                            ImageUrl = "",
                            ListPrice = 15.99,
                            Price = 12.99,
                            Price100 = 10.99,
                            Price50 = 11.99,
                            Title = "The Catcher in the Rye"
                        },
                        new
                        {
                            Id = 6,
                            Author = "William Golding",
                            CategoryId = 1,
                            Description = "A novel by William Golding",
                            ISBN = "978-0399501487",
                            ImageUrl = "",
                            ListPrice = 13.99,
                            Price = 11.99,
                            Price100 = 9.9900000000000002,
                            Price50 = 10.99,
                            Title = "Lord of the Flies"
                        },
                        new
                        {
                            Id = 7,
                            Author = "J.R.R. Tolkien",
                            CategoryId = 3,
                            Description = "A novel by J.R.R. Tolkien",
                            ISBN = "978-0547928227",
                            ImageUrl = "",
                            ListPrice = 18.989999999999998,
                            Price = 15.99,
                            Price100 = 13.99,
                            Price50 = 14.99,
                            Title = "The Hobbit"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Herman Melville",
                            CategoryId = 1,
                            Description = "A novel by Herman Melville",
                            ISBN = "978-0142437247",
                            ImageUrl = "",
                            ListPrice = 17.989999999999998,
                            Price = 14.99,
                            Price100 = 12.99,
                            Price50 = 13.99,
                            Title = "Moby-Dick"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Oscar Wilde",
                            CategoryId = 1,
                            Description = "A novel by Oscar Wilde",
                            ISBN = "978-1503299643",
                            ImageUrl = "",
                            ListPrice = 11.99,
                            Price = 9.9900000000000002,
                            Price100 = 7.9900000000000002,
                            Price50 = 8.9900000000000002,
                            Title = "The Picture of Dorian Gray"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Mary Shelley",
                            CategoryId = 3,
                            Description = "A novel by Mary Shelley",
                            ISBN = "978-0486282114",
                            ImageUrl = "",
                            ListPrice = 14.99,
                            Price = 11.99,
                            Price100 = 9.9900000000000002,
                            Price50 = 10.99,
                            Title = "Frankenstein"
                        },
                        new
                        {
                            Id = 11,
                            Author = "Aldous Huxley",
                            CategoryId = 1,
                            Description = "A novel by Aldous Huxley",
                            ISBN = "978-0060850524",
                            ImageUrl = "",
                            ListPrice = 16.989999999999998,
                            Price = 13.99,
                            Price100 = 11.99,
                            Price50 = 12.99,
                            Title = "Brave New World"
                        },
                        new
                        {
                            Id = 12,
                            Author = "Mark Twain",
                            CategoryId = 3,
                            Description = "A novel by Mark Twain",
                            ISBN = "978-0486400778",
                            ImageUrl = "",
                            ListPrice = 12.99,
                            Price = 10.99,
                            Price100 = 8.9900000000000002,
                            Price50 = 9.9900000000000002,
                            Title = "The Adventures of Tom Sawyer"
                        },
                        new
                        {
                            Id = 13,
                            Author = "Bram Stoker",
                            CategoryId = 2,
                            Description = "A novel by Bram Stoker",
                            ISBN = "978-0486411095",
                            ImageUrl = "",
                            ListPrice = 13.99,
                            Price = 11.99,
                            Price100 = 9.9900000000000002,
                            Price50 = 10.99,
                            Title = "Dracula"
                        },
                        new
                        {
                            Id = 14,
                            Author = "Alexandre Dumas",
                            CategoryId = 3,
                            Description = "A novel by Alexandre Dumas",
                            ISBN = "978-0141392462",
                            ImageUrl = "",
                            ListPrice = 19.989999999999998,
                            Price = 16.989999999999998,
                            Price100 = 14.99,
                            Price50 = 15.99,
                            Title = "The Count of Monte Cristo"
                        },
                        new
                        {
                            Id = 15,
                            Author = "Nathaniel Hawthorne",
                            CategoryId = 1,
                            Description = "A novel by Nathaniel Hawthorne",
                            ISBN = "978-0142423356",
                            ImageUrl = "",
                            ListPrice = 15.99,
                            Price = 12.99,
                            Price100 = 10.99,
                            Price50 = 11.99,
                            Title = "The Scarlet Letter"
                        },
                        new
                        {
                            Id = 16,
                            Author = "Lewis Carroll",
                            CategoryId = 3,
                            Description = "A novel by Lewis Carroll",
                            ISBN = "978-0486275437",
                            ImageUrl = "",
                            ListPrice = 10.99,
                            Price = 8.9900000000000002,
                            Price100 = 6.9900000000000002,
                            Price50 = 7.9900000000000002,
                            Title = "Alice's Adventures in Wonderland"
                        },
                        new
                        {
                            Id = 18,
                            Author = "Emily Brontë",
                            CategoryId = 2,
                            Description = "A novel by Emily Brontë",
                            ISBN = "978-0141439556",
                            ImageUrl = "",
                            ListPrice = 14.99,
                            Price = 11.99,
                            Price100 = 9.9900000000000002,
                            Price50 = 10.99,
                            Title = "Wuthering Heights"
                        });
                });

            modelBuilder.Entity("bookstore.Models.Product", b =>
                {
                    b.HasOne("bookstore.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
