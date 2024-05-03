﻿using WorigoApp.Application.Interfaces.Repositories;
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

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public async Task CommitAsync()
        {
            await dbContext.Database.CommitTransactionAsync();
        }

        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();

        public void OpenTransaction()
        {
            dbContext.Database.BeginTransactionAsync();
        }

        public void RollBack()
        {
            dbContext.Database.RollbackTransaction();
        }

        public int Save() => dbContext.SaveChanges();
        public async Task<int> SaveAsync()
        {

            try
            {
                var result = await dbContext.SaveChangesAsync(); ;
                return result;
            }
            catch (Exception ex)
            {
                RollBack();
                throw new Exception(ex.Message);

            }
        }

        public async Task SaveAsync1()
        {
            try
            {
                await dbContext.SaveChangesAsync();
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
