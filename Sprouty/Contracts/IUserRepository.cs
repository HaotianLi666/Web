/* File: IUserRepository.cs
 * Authors: Jonathan Wenek
 * Purpose: Public interface of the user repository
 * Functions: GetAll(), GetUserById(), CreateUser(), UpdateUser(), DeleteUser() */
using Sprouty.Entities.Models;

namespace Sprouty.Contracts
{
    /* Interface: IUserRepository
     * Purpose: Defines the functions which must be implemented by any class which implements this interface */
    public interface IUserRepository
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        User GetUserById(string id);
        User GetUserByEmail(string email);
        void CreateUser(User user);
        void UpdateUser(string id, User user);
        void DeleteUser(string id);
    }
}
