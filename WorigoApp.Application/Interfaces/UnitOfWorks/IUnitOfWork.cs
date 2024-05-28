using WorigoApp.Application.Interfaces.Repositories;
using WorigoApp.Domain.Common;

namespace WorigoApp.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : class, IEntityBase, new();
        IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntityBase, new();
        void OpenTransaction();
        Task<int> SaveAsync();
        Task CommitAsync();
        void RollBack();
        int Save();
    }
}
