using WorigoApp.Application.Interfaces.Repositories;
using WorigoApp.Domain.Common;

namespace WorigoApp.Application.Interfaces.UnitOfWorks
{
/// <summary>
/// IUnitOfWork arayüzünü tanımlar.
/// </summary>
public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : class, IEntityBase, new();
        IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntityBase, new();
        Task OpenTransactionAsync(CancellationToken cancellationToken);
        Task<int> SaveAsync(CancellationToken cancellationToken = default);
        Task CommitAsync(CancellationToken cancellationToken = default);
        Task RollBackAsync(CancellationToken cancellationToken = default);
    }
}
