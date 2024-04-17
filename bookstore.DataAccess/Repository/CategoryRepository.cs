using bookstore.DataAccess.Data;
using bookstore.DataAccess.Repository.IRepository;
using bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly BookStoreDBContext ctx;

        public CategoryRepository(BookStoreDBContext ctx) : base(ctx) 
        {
            this.ctx = ctx;
        }

        public void Update(Category category)
        {
            ctx.Categories.Update(category);
        }
    }
}
