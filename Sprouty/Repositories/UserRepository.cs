using Sprouty.Contracts;
using Sprouty.Entities;
using Sprouty.Entities.Models;
using System;
using System.Collections.Generic;

namespace Sprouty.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext context) : base(context) { }

        public IEnumerable<User> GetAll()
        {
            // TODO : implement interface functions, see UML
            throw new NotImplementedException();
        }

        public User GetUserById(string id)
        {
            // TODO : implement interface functions, see UML
            throw new NotImplementedException();
        }
    }
}
