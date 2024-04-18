using bookstore.DataAccess.Data;
using bookstore.DataAccess.Repository.IRepository;
using bookstore.Models;

namespace bookstore.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly BookStoreDBContext ctx;

        public ShoppingCartRepository(BookStoreDBContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }

        public void Update(ShoppingCart shoppingCart)
        {
            ctx.ShoppingCarts.Update(shoppingCart);
        }
    }
}
