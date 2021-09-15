/* File: RepositoryWrapper.cs
 * Authors: Jonathan Wenek
 * Purpose: 
 *      Generic wrapper class which exposes the IUserRepository and IPlantRepository interface classes to their 
 *      respective controller classes */
using Sprouty.Contracts;
using Sprouty.Entities;

namespace Sprouty.Repositories
{
    /* Class: RepositoryWrapper
     * Authors: Jonathan Wenek
     * Implements: IRepositoryWrapper
     * Purpose: Provide public get access to the IUserRepository and IPlantRepository interface classes
     * Properties:
     *      _context<RepositoryContext>, manages the connection to MongoDB
     *      _user<IUserRepository>, provides access to the functions in this interface wwithout exposing the internal logic
     *      _plant<IPlantRepository>, provides acccess to the functions in this interface without exposing the internal logic */
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _context;
        private IUserRepository _user;
        private IPlantRepository _plant;

        public RepositoryWrapper(RepositoryContext context)
        {
            _context = context;
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                    _user = new UserRepository(_context);

                return _user;
            }
        }

        public IPlantRepository Plant
        {
            get
            {
                if (_plant == null)
                    _plant = new PlantRepository(_context);

                return _plant;
            }
        }
    }
}
