using Entities.Abstract;
using System.Collections.Generic;
using DataAccess.Concrete;

namespace DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(ETradeTools eTradeConnection);
        T Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}