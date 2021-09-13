using Sprouty.Contracts;
using Sprouty.Entities;

namespace Sprouty.Repositories
{
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
