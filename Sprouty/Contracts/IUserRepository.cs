using Sprouty.Entities.Models;
using System.Collections.Generic;

namespace Sprouty.Contracts
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetUserById(string id);
        void CreateUser(User user);
        void UpdateUser(string id, User user);
        void DeleteUser(string id);
    }
}
