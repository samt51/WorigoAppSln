using WorigoApp.Domain.Common;

namespace WorigoApp.Application.Interfaces.Repositories
{
/// <summary>
/// IWriteRepository arayüzünü tanımlar.
/// </summary>
public interface IWriteRepository<T> where T : class, IEntityBase, new()
    {
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(IList<T> entities);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task SoftDeleteAsync(T entity);
        Task HardDeleteRangeAsync(IList<T> entity);
    }
}
