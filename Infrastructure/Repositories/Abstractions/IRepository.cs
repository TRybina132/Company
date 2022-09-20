using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using System;

namespace Infrastructure.Repositories.Abstractions
{
    public interface IRepository<T>
    {
        Task<ICollection<T>> GetAllAsync(
            bool asNoTracking = true,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            Expression<Func<T, bool>>? filter = null);

        Task<T?> GetByIdAsync(int id);

        Task InsertAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveChangesAsync();
    }
}
