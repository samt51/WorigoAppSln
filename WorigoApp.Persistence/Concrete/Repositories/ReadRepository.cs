using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using SendGrid.Helpers.Errors.Model;
using System.Linq.Expressions;
using WorigoApp.Application.Interfaces.Repositories;
using WorigoApp.Domain.Common;

namespace WorigoApp.Persistence.Concrete.Repositories
{
    /// <summary>
    /// ReadRepository sınıfını temsil eder.
    /// </summary>
    public class ReadRepository<T> : IReadRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext dbContext;
/// <summary>
/// ReadRepository sınıfının yeni bir örneğini başlatır.
/// </summary>
public ReadRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> Table { get => dbContext.Set<T>(); }
/// <summary>
/// GetAllAsync işlemini gerçekleştirir.
/// </summary>
public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, Expression<Func<T, T>>? selector = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) queryable = include(queryable);
            if (predicate is not null) queryable = queryable.Where(predicate);
            if (orderBy is not null)
                return await orderBy(queryable).ToListAsync();

            if (selector is not null)
            {
                return await queryable.Select(selector).ToListAsync();
            }

            return await queryable.ToListAsync();
        }
/// <summary>
/// GetAllByPagingAsync işlemini gerçekleştirir.
/// </summary>
public async Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false, int currentPage = 1, int pageSize = 3)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) queryable = include(queryable);
            if (predicate is not null) queryable = queryable.Where(predicate);
            if (orderBy is not null)
                return await orderBy(queryable).Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
            return await queryable.Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
        }
        /// <summary>
        /// Exception GetFirst
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="include"></param>
        /// <param name="enableTracking"></param>
        /// <returns></returns>
        /// <exception cref="NotFoundException"></exception>
        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) queryable = include(queryable);

            //queryable.Where(predicate);

            var data = await queryable.FirstOrDefaultAsync(predicate);
            if (data is null)
            {
                throw new NotFoundException($"{typeof(T).Name} Is Not Found");
            }
            return data;
        }
/// <summary>
/// CountAsync işlemini gerçekleştirir.
/// </summary>
public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            Table.AsNoTracking();
            if (predicate is not null) Table.Where(predicate);

            return await Table.CountAsync();
        }
        /// <summary>
        /// Not Exception Controll
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="include"></param>
        /// <param name="enableTracking"></param>
        /// <returns></returns>
        public async Task<T> FindAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) queryable = include(queryable);

            //queryable.Where(predicate);

            return await queryable.FirstOrDefaultAsync(predicate);

        }
    }
}
