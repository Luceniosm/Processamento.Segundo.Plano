using System;
using System.Data.Entity;

namespace Data.UnitOfWork
{
    public interface IUnitOfWork<T> where T : DbContext, IDisposable
    {
        void BeginTransaction();

        void Commit();

        void CommitAsync();
    }
}