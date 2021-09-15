using MongoDB.Driver;
using Sprouty.Contracts;
using Sprouty.Entities;
using Sprouty.Entities.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Sprouty.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : BaseModel
    {
        private MongoDbContext _context;
        private IMongoCollection<T> _collection { get; set; }

        public RepositoryBase(MongoDbContext context)
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
