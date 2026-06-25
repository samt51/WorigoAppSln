using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Interfaces.Repositories;
using WorigoApp.Domain.Common;

namespace WorigoApp.Persistence.Concrete.Repositories
{
    /// <summary>
    /// WriteRepository sınıfını temsil eder.
    /// </summary>
    public class WriteRepository<T> : IWriteRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext dbContext;
/// <summary>
/// WriteRepository sınıfının yeni bir örneğini başlatır.
/// </summary>
public WriteRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> Table { get => dbContext.Set<T>(); }
/// <summary>
/// AddAsync işlemini gerçekleştirir.
/// </summary>
public async Task<T> AddAsync(T entity)
        {

            var tab = await Table.AddAsync(entity).ConfigureAwait(false);
            return tab.Entity;


        }
/// <summary>
/// AddRangeAsync işlemini gerçekleştirir.
/// </summary>
public async Task AddRangeAsync(IList<T> entities)
        {
            await Table.AddRangeAsync(entities);
        }
/// <summary>
/// UpdateAsync işlemini gerçekleştirir.
/// </summary>
public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }
/// <summary>
/// HardDeleteRangeAsync işlemini gerçekleştirir.
/// </summary>
public async Task HardDeleteRangeAsync(IList<T> entity)
        {
            await Task.Run(() => Table.RemoveRange(entity));
        }
/// <summary>
/// SoftDeleteAsync işlemini gerçekleştirir.
/// </summary>
public async Task SoftDeleteAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
        }
/// <summary>
/// DeleteAsync işlemini gerçekleştirir.
/// </summary>
public async Task<T> DeleteAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }
    }
}
