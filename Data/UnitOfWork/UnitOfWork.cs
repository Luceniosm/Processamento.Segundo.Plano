using System;
using System.Data.Entity;

namespace Data.UnitOfWork
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext>
           where TContext : DbContext, new()
    {
        private readonly TContext _context;

        private bool _disposed;

        public UnitOfWork(TContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void CommitAsync()
        {
            _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}