﻿using bookstore.DataAccess.Data;
using bookstore.DataAccess.Repository.IRepository;

namespace bookstore.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private BookStoreDBContext ctx;

        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }

        public UnitOfWork(BookStoreDBContext ctx)
        {
            this.ctx = ctx;
            Category = new CategoryRepository(ctx);
            Product = new ProductRepository(ctx);
        }


        public void Save()
        {
            ctx.SaveChanges();
        }
    }
}
