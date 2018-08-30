using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> GetPagination(Expression<Func<TEntity, bool>> predicate, int take, int skip);

        Task<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);

        TEntity Insert(TEntity obj);

        TEntity Update(TEntity obj);

        void Delete(int id);

        int SaveChanges();
    }
}