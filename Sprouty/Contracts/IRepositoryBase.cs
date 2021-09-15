using System;
using System.Linq;
using System.Linq.Expressions;

namespace Sprouty.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> filter);
        void Create(T entity);
        void Update(Expression<Func<T, bool>> filter, T entity);
        void Delete(Expression<Func<T, bool>> filter);
    }
}
