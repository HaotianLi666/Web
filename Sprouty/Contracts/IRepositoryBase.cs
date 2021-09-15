/* File: IRepositoryBase.cs
 * Authors: Jonathan Wenek
 * Purpose: Generic base repository which the user and plant repositories inherit from
 * Functions: FindAll(), FindByCondition(), Create(), Update(), Delete() */
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Sprouty.Contracts
{
    /* Interface: IRepositoryBase
     * Pupose: Defines the functions which must be implemented by any class which implements this interface */
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> filter);
        void Create(T entity);
        void Update(Expression<Func<T, bool>> filter, T entity);
        void Delete(Expression<Func<T, bool>> filter);
    }
}
