using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bookstore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductsTableToBookDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "A novel by F. Scott Fitzgerald", "978-0743273565", 14.99, 12.99, 10.99, 11.99, "The Great Gatsby" },
                    { 2, "Harper Lee", "A novel by Harper Lee", "978-0061120084", 16.989999999999998, 13.99, 11.99, 12.99, "To Kill a Mockingbird" },
                    { 3, "George Orwell", "A novel by George Orwell", "978-0452284234", 12.99, 10.99, 8.9900000000000002, 9.9900000000000002, "1984" },
                    { 4, "Jane Austen", "A novel by Jane Austen", "978-0486284736", 10.99, 8.9900000000000002, 6.9900000000000002, 7.9900000000000002, "Pride and Prejudice" },
                    { 5, "J.D. Salinger", "A novel by J.D. Salinger", "978-0316769488", 15.99, 12.99, 10.99, 11.99, "The Catcher in the Rye" },
                    { 6, "William Golding", "A novel by William Golding", "978-0399501487", 13.99, 11.99, 9.9900000000000002, 10.99, "Lord of the Flies" },
                    { 7, "J.R.R. Tolkien", "A novel by J.R.R. Tolkien", "978-0547928227", 18.989999999999998, 15.99, 13.99, 14.99, "The Hobbit" },
                    { 8, "Herman Melville", "A novel by Herman Melville", "978-0142437247", 17.989999999999998, 14.99, 12.99, 13.99, "Moby-Dick" },
                    { 9, "Oscar Wilde", "A novel by Oscar Wilde", "978-1503299643", 11.99, 9.9900000000000002, 7.9900000000000002, 8.9900000000000002, "The Picture of Dorian Gray" },
                    { 10, "Mary Shelley", "A novel by Mary Shelley", "978-0486282114", 14.99, 11.99, 9.9900000000000002, 10.99, "Frankenstein" },
                    { 11, "Aldous Huxley", "A novel by Aldous Huxley", "978-0060850524", 16.989999999999998, 13.99, 11.99, 12.99, "Brave New World" },
                    { 12, "Mark Twain", "A novel by Mark Twain", "978-0486400778", 12.99, 10.99, 8.9900000000000002, 9.9900000000000002, "The Adventures of Tom Sawyer" },
                    { 13, "Bram Stoker", "A novel by Bram Stoker", "978-0486411095", 13.99, 11.99, 9.9900000000000002, 10.99, "Dracula" },
                    { 14, "Alexandre Dumas", "A novel by Alexandre Dumas", "978-0141392462", 19.989999999999998, 16.989999999999998, 14.99, 15.99, "The Count of Monte Cristo" },
                    { 15, "Nathaniel Hawthorne", "A novel by Nathaniel Hawthorne", "978-0142423356", 15.99, 12.99, 10.99, 11.99, "The Scarlet Letter" },
                    { 16, "Lewis Carroll", "A novel by Lewis Carroll", "978-0486275437", 10.99, 8.9900000000000002, 6.9900000000000002, 7.9900000000000002, "Alice's Adventures in Wonderland" },
                    { 18, "Emily Brontë", "A novel by Emily Brontë", "978-0141439556", 14.99, 11.99, 9.9900000000000002, 10.99, "Wuthering Heights" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
