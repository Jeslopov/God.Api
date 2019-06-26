using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace UruIt.God.Services.Abstractions
{
    public interface IService<IEntity>
    {
        IEntity Get(int id);
        IEnumerable<IEntity> GetAll();
        IEnumerable<IEntity> Find(Expression<Func<IEntity, bool>> predicate);
        void Add(IEntity entity);
        void AddRange(IEnumerable<IEntity> entities);
    }
}
