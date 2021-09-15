using Sprouty.Contracts;
using Sprouty.Entities;
using Sprouty.Entities.Models;
using System;
using System.Collections.Generic;

namespace Sprouty.Repositories
{
    public class PlantRepository : RepositoryBase<Plant>, IPlantRepository
    {
        public PlantRepository(RepositoryContext context) : base(context) { }

        public IEnumerable<Plant> GetAll()
        {
            throw new NotImplementedException();
        }

        public Plant GetPlantById(string id)
        {
            throw new NotImplementedException();
        }
        public void CreatePlant(Plant plant)
        {
            throw new NotImplementedException();
        }

        public void UpdatePlant(string id, Plant plant)
        {
            throw new NotImplementedException();
        }
        public void DeleteClient(string id)
        {
            throw new NotImplementedException();
        }
    }
}
