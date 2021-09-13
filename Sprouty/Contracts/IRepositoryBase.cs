using System;
using System.Linq;
using System.Linq.Expressions;

namespace Sprouty.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> filter);

        // TODO : add  the rest of the base interface functions, see UML
    }
}
