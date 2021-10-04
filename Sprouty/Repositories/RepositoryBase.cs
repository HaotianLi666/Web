/* File: RepositoryBase.cs
 * Authors: Jonathan Wenek
 * Purpose: This is an abstract generic class which all other repository classes will inherit from
 * Functions:
 *      RepositoryBase(), FindAll(), FindByCondition(), Create(), Update(), Delete() */

using MongoDB.Driver;
using Sprouty.Contracts;
using Sprouty.Entities;
using Sprouty.Entities.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Sprouty.Repositories
{
    /* Class: RepositoryBase<T>
     * Implements: IRepositoryBase<T> where T is of type BaseModel
     * Purpose:
     *      Provides a generic Repository class which can be inherted by the specific User and Plant repository classes
     *      where T is type BaseModel (which BaseModel, User, and Plant are all derived from).
     *      The functions are implemented in a manner which allows for repeated use by User or Plant interfaces, where more specific
     *      logic can be utilized.
     * Properties:
     *      _context<RepositoryContext>, manages the connection to MongoDB
     *      _collection<IMongoCollection>, private access to the interface which allows access to a MongoDB collection */
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : BaseModel
    {
        private RepositoryContext _context;
        private IMongoCollection<T> _collection { get; set; }

        public RepositoryBase(RepositoryContext context)
        {
            if (context == null)
                return;

            _context = context;
            _collection = _context.DbSet<T>();
        }

        public IQueryable<T> FindAll()
        {
            return _collection.AsQueryable();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> filter)
        {
            return _collection.AsQueryable().Where(filter);
        }

        public void Create(T entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(Expression<Func<T, bool>> filter, T entity)
        {
            _collection.FindOneAndReplace(filter, entity);
        }

        public void Delete(Expression<Func<T, bool>> filter)
        {
            _collection.DeleteMany(filter);
        }
    }
}
