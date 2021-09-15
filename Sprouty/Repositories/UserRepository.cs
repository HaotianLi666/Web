/* File: UserRepository.cs
 * Authors: Jonathan Wenek, Cameron Carley, Stephanie Cameron
 * Purpose: Implements the IUserRepository interface
 * Functions:
 *      UserRepository(), GetAll(), GetUserById(), CreateUser(), UpdateUser(), DeleteUser() */

using Sprouty.Contracts;
using Sprouty.Entities;
using Sprouty.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sprouty.Repositories
{
    /* Class: UserRepository
     * Inherits: RepositoryBase<User>
     * Implements: IUserRepository 
     * Purpose: 
     *      To provide the specific implementation of RepositoryBase for type User provided by the interface contract 
     *      in IUserRepository */
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext context):base(context) { }

        public IEnumerable<User> GetAllUsers()
        {
            return FindAll().OrderBy(u=>u.Id).ToList<User>();
        }

        public User GetUserById(string id)
        {
            return FindByCondition(p => p.Id == id).FirstOrDefault();
        }
        public void CreateUser(User user)
        {
            Create(user);
        }
        public void UpdateUser(string id, User user)
        {
            var temp = this.GetUserById(id);
            if (temp == null)
            {
                throw new Exception("User does not exist");
            }
            Update((p => p.Id == id), user);
        }

        public void DeleteUser(string id)
        {
            var temp = this.GetUserById(id);
            if (temp == null)
            {
                throw new Exception("User does not exist");
            }
            Delete((p => p.Id == id));
        }
    }
}
