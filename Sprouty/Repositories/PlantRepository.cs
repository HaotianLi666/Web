using Sprouty.Contracts;
using Sprouty.Entities;
using Sprouty.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sprouty.Repositories
{
    public class PlantRepository : RepositoryBase<Plant>, IPlantRepository
    {
        public PlantRepository(RepositoryContext context) : base(context) { }

        public IEnumerable<Plant> GetAllPlants()
        {
            return FindAll().OrderBy(p => p.Id).ToList<Plant>();
        }

        public Plant GetPlantById(string id)
        {
            return FindByCondition(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<Plant> GetPlantsByUserId(Guid userId)
        {
            return FindByCondition(p => p.UserId == userId).ToList().Sort((x, y) => DateTime.Compare(x., y.Created));
        }

        public void CreatePlant(Plant plant)
        {
            Create(plant);
        }

        public void UpdatePlant(string id, Plant plant)
        {
            var temp = this.GetPlantById(id);
            if (temp == null)
            {
                throw new Exception("Plant does not exist");
            }
            Update((p=>p.Id==id),plant);
        }
        public void DeletePlant(string id)
        {
          
            var temp = this.GetPlantById(id);
            if (temp == null)
            {
                throw new Exception("Plant does not exist");
            }
            Delete((p => p.Id == id));
        }
    }
}
