using WorigoApp.Application.Interfaces.Repositories;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Persistence.Concrete.Repositories;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Persistence.Concrete.UnitOfWorks
{
    /// <summary>
    /// UnitOfWork sınıfını temsil eder.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;
/// <summary>
/// UnitOfWork sınıfının yeni bir örneğini başlatır.
/// </summary>
public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
/// <summary>
/// CommitAsync işlemini gerçekleştirir.
/// </summary>
public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
            if (dbContext.Database.CurrentTransaction == null) return;
            await dbContext.Database.CommitTransactionAsync(cancellationToken);
        }
/// <summary>
/// RollBackAsync işlemini gerçekleştirir.
/// </summary>
public async Task RollBackAsync(CancellationToken cancellationToken = default)
        {
            if (dbContext.Database.CurrentTransaction == null) return;
            await dbContext.Database.RollbackTransactionAsync(cancellationToken);
        }
/// <summary>
/// DisposeAsync işlemini gerçekleştirir.
/// </summary>
public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();
/// <summary>
/// OpenTransactionAsync işlemini gerçekleştirir.
/// </summary>
public async Task OpenTransactionAsync(CancellationToken cancellationToken)
        {
            if (dbContext.Database.CurrentTransaction != null)
                return;

            await dbContext.Database.BeginTransactionAsync(cancellationToken);
        }
/// <summary>
/// SaveAsync işlemini gerçekleştirir.
/// </summary>
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
