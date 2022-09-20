using Infrastructure.Context;
using Infrastructure.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Infrastructure.Repositories
{
    internal abstract class Repository<T> : IRepository<T> 
        where T : class
    {
        private readonly ProductContext productContext;
        protected readonly DbSet<T> dbSet;

        protected Repository(ProductContext productContext)
        {
            this.productContext = productContext;
            dbSet = productContext.Set<T>();
        }

        public async Task<ICollection<T>> GetAllAsync(
            bool asNoTracking = true,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, 
            Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> query = filter == null ?
                dbSet : dbSet.Where(filter);

            if (include != null)
                query = include(query);

            if (asNoTracking)
                query = query.AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id) =>
            await dbSet.FindAsync(id);

        public async Task InsertAsync(T entity) =>
            await dbSet.AddAsync(entity);

        public void Update(T entity)
        {
            if (productContext.Entry(entity).State == EntityState.Detached)
                productContext.Attach(entity);

            productContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity) =>
            productContext.Entry(entity).State = EntityState.Deleted;

        public async Task SaveChangesAsync() =>
            await productContext.SaveChangesAsync();
    }
}
