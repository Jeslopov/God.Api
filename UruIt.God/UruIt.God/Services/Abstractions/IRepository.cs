using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UruIt.God.Domain.Abstractions;


namespace UruIt.God.Services.Abstractions
{
    public interface IRepository<IEntity>
    {
        IEntity Get(int id);
        IEnumerable<IEntity> GetAll();
        IEnumerable<IEntity> Find(Expression<Func<IEntity, bool>> predicate);

        
        IEntity SingleOrDefault(Expression<Func<IEntity, bool>> predicate);

        void Add(IEntity entity);
        void AddRange(IEnumerable<IEntity> entities);

        void Remove(IEntity entity);
        void RemoveRange(IEnumerable<IEntity> entities);
    }
}
