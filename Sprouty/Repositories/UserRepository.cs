/* File: UserRepository.cs
 * Authors: Jonathan Wenek, Cameron Carley, Stephanie Cameron
 * Purpose: Implements the IUserRepository interface
 * Functions:
 *      UserRepository(), GetAll(), GetUserById(), CreateUser(), UpdateUser(), DeleteUser() */

using Microsoft.Extensions.Options;
using System.Linq;
using Sprouty.Contracts;
using Sprouty.Entities;
using Sprouty.Entities.Models;
using Sprouty.Helpers;
using Sprouty.Services;

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
        private readonly AppSettings _appsettings;
        private readonly IUserService _userService;

        public UserRepository(IUserService userService, IOptions<AppSettings> appSettings, RepositoryContext context):base(context) 
        {
            _appsettings = appSettings.Value;
            _userService = userService;
        }

        //public UserRepository(RepositoryContext context) : base(context) { }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = FindByCondition(p => p.UserId == model.UserId).FirstOrDefault();
            if (user == null)
                return null;

            var hashed = _userService.HashPassword(model.Password, user.Salt);
            if (user.Password != hashed)
                return null;

            var token = _userService.GenerateJwtToken(user);
            return new AuthenticateResponse(user, token);
        }

        public User GetUserById(string id)
        {
            return FindByCondition(p => p.Id == id).FirstOrDefault();
        }

        public User GetUserByEmail(string email)
        {
            return FindByCondition(p => p.EmailAddress == email).FirstOrDefault();
        }

        public void CreateUser(User user)
        {
            Create(user);
        }

        public void UpdateUser(string id, User user)
        {
            Update((p => p.Id == id), user);
        }

        public void DeleteUser(string id)
        {
            Delete((p => p.Id == id));
        }
    }
}
