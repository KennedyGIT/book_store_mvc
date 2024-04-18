using bookstore.DataAccess.Data;
using bookstore.DataAccess.Repository.IRepository;
using bookstore.Models;

namespace bookstore.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly BookStoreDBContext ctx;

        public ProductRepository(BookStoreDBContext ctx) : base(ctx) 
        {
            this.ctx = ctx;
        }

        public void Update(Product product)
        {
           var existingProduct = ctx.Products.FirstOrDefault(p => p.Id == product.Id);
           if (existingProduct != null) 
            {
                existingProduct.Title = product.Title;
                existingProduct.Description = product.Description;
                existingProduct.CategoryId = product.CategoryId;
                existingProduct.Price = product.Price;
                existingProduct.Price50 = product.Price50;
                existingProduct.Price100 = product.Price100;
                existingProduct.Author = product.Author;
                existingProduct.ISBN = product.ISBN;
                existingProduct.ListPrice = product.ListPrice;

                if(existingProduct.ImageUrl != null) 
                {
                    existingProduct.ImageUrl = product.ImageUrl;
                }
            }
        }
    }
}
