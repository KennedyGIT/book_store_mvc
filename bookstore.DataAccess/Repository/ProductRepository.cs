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
            ctx.Products.Update(product);
        }
    }
}
