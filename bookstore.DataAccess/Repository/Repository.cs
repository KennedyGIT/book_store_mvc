using bookstore.DataAccess.Data;
using bookstore.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace bookstore.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BookStoreDBContext ctx;
        internal DbSet<T> dbSet;

        public Repository(BookStoreDBContext ctx)
        {
            this.ctx = ctx;
            this.dbSet = ctx.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }
    }
}
