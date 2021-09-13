using Sprouty.Entities.Models;
using System.Collections.Generic;

namespace Sprouty.Contracts
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetUserById(string id);

        // TODO : add the rest of the interface functions, see UML
    }
}
