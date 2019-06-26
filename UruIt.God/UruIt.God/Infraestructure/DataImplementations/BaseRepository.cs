using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UruIt.God.Infraestructure.DbContexts;
using UruIt.God.Domain.Entities;
using UruIt.God.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace UruIt.God.Infraestructure.DataImplementations
{
    public abstract class BaseRepository<IEntity> : IRepository<IEntity> where IEntity : class
    {
        protected readonly DbContext Context;

        public BaseRepository(DbContext context)
        {
            Context = context;
        }

        public IEntity Get(int id)
        {
            return Context.Set<IEntity>().Find(id);
        }

        public IEnumerable<IEntity> GetAll()
        {
            
            return Context.Set<IEntity>().ToList();
        }

        public IEnumerable<IEntity> Find(Expression<Func<IEntity, bool>> predicate)
        {
            return Context.Set<IEntity>().Where(predicate);
        }

        public IEntity SingleOrDefault(Expression<Func<IEntity, bool>> predicate)
        {
            return Context.Set<IEntity>().SingleOrDefault(predicate);
        }

        public void Add(IEntity entity)
        {
            Context.Set<IEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<IEntity> entities)
        {
            Context.Set<IEntity>().AddRange(entities);
        }

        public void Remove(IEntity entity)
        {
            Context.Set<IEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<IEntity> entities)
        {
            Context.Set<IEntity>().RemoveRange(entities);
        }
    }
}
