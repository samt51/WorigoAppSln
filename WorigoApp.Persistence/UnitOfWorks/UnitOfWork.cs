
using WorigoApp.Application.Interfaces.Repositories;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Persistence.Context;
using WorigoApp.Persistence.Repositories;

namespace WorigoApp.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public void Commit()
        {
            this.dbContext.Database.CommitTransaction();
        }

        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();

        public void OpenTransaction()
        {
            this.dbContext.Database.BeginTransaction();
        }

        public void RollBack()
        {
            this.dbContext.Database.RollbackTransaction();
        }

        public int Save() => dbContext.SaveChanges();
        public async Task<int> SaveAsync()
        {
            try
            {
                return await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                var error = ex.InnerException?.Message;

                throw;
            }
        }
        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(dbContext);



        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>()
        {
            return new WriteRepository<T>(dbContext);
        }
    }
}
