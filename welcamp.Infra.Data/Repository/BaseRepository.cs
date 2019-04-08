using System;
using System.Collections.Generic;
using System.Text;
using welcamp.Domain.Entities;
using welcamp.Domain.Interfaces;
using welcamp.Infra.Data.Context;

namespace welcamp.Infra.Data.Repository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbConnection context = new DbConnection();

        public void Insert(TEntity obj)
        {
            context.Set<TEntity>().Add(obj);
            context.SaveChanges();

        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity Select(int id)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> SelectALL()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
