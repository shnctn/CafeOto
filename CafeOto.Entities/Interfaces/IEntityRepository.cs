using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace CafeOto.Entities.Interfaces
{
    public interface IEntityRepository<TContext, TEntity>
    where TContext : DbContext, new()
    where TEntity : IEntity, new()
    {
        List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null);
        TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter);
        bool AddOrUpdate(TContext context, TEntity entity);
        void Delete(TContext context, Expression<Func<TEntity, bool>> filter);
        void save(TContext context);




    }
}
