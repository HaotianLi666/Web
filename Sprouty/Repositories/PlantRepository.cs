using Sprouty.Contracts;
using Sprouty.Entities;
using Sprouty.Entities.Models;
using System;
using System.Collections.Generic;

namespace Sprouty.Repositories
{
    public class PlantRepository : RepositoryBase<Plant>, IPlantRepository
    {
        public PlantRepository(MongoDbContext context) : base(context) { }

        public IEnumerable<Plant> GetAll()
        {
            // TODO : implement interface functions, see UML
            throw new NotImplementedException();
        }

        public Plant GetPlantById(string id)
        {
            // TODO : implement interface functions, see UML
            throw new NotImplementedException();
        }
    }
}
