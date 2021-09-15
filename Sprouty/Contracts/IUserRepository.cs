/* File: IUserRepository.cs
 * Authors: Jonathan Wenek
 * Purpose: Public interface of the user repository
 * Functions: GetAll(), GetUserById(), CreateUser(), UpdateUser(), DeleteUser() */
using Sprouty.Entities.Models;
using System.Collections.Generic;

namespace Sprouty.Contracts
{
    /* Interface: IUserRepository
     * Purpose: Defines the functions which must be implemented by any class which implements this interface */
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(string id);
        void CreateUser(User user);
        void UpdateUser(string id, User user);
        void DeleteUser(string id);
    }
}
