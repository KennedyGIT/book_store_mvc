using bookstore.DataAccess.Data;
using bookstore.DataAccess.Repository.IRepository;
using bookstore.Models;

namespace bookstore.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly BookStoreDBContext ctx;

        public ApplicationUserRepository(BookStoreDBContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }

    }
}
