using WorigoApp.Application.Interfaces.Repositories;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Persistence.Concrete.Repositories;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Persistence.Concrete.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
            if (dbContext.Database.CurrentTransaction == null) return;
            await dbContext.Database.CommitTransactionAsync(cancellationToken);
        }

        public async Task RollBackAsync(CancellationToken cancellationToken = default)
        {
            if (dbContext.Database.CurrentTransaction == null) return;
            await dbContext.Database.RollbackTransactionAsync(cancellationToken);
        }

        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();

        public async Task OpenTransactionAsync(CancellationToken cancellationToken)
        {
            if (dbContext.Database.CurrentTransaction != null)
                return;

            await dbContext.Database.BeginTransactionAsync(cancellationToken);
        }

        public async Task<int> SaveAsync(CancellationToken cancellationToken = default)
        {

            try
            {
                var result = await dbContext.SaveChangesAsync(cancellationToken);
                return result;
            }
            catch (Exception ex)
            {
                await RollBackAsync(cancellationToken);
                throw new Exception(ex.Message);

            }
        }
        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(dbContext);
        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(dbContext);

    }
}
