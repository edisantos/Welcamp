using System.Collections.Generic;
using welcamp.Domain.Entities;

namespace welcamp.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity: BaseEntity
    {
        void Insert(TEntity obj);

        void Update(TEntity obj);

        void Remove(int id);

        TEntity Select(int id);

        IList<TEntity> SelectALL();
    }
}
