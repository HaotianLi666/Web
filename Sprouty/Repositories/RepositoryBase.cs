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
                return; // TODO : add logging

            _context = context;
            _collection = _context.DbSet<T>();
        }

        public IQueryable<T> FindAll()
        {
            // TODO: implement interface functions, see UML
            throw new NotImplementedException();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> filter)
        {
            // TODO: implement interface functions, see UML
            throw new NotImplementedException();
        }
    }
}
