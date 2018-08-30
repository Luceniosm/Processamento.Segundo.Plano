using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(Guid id);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> GetAll();

        TEntity Insert(TEntity obj);

        TEntity Update(TEntity obj);

        void Delete(Guid id);

        int SaveChanges();
    }
}