/* File: PlantRepository.cs
 * Authors: Jonathan Wenek, Cameron Carley, Stephanie Cameron
 * Purpose: Implements the IPlantRepository interface
 * Functions:
 *      PlantRepository(), GetAll(), GetPlantById(), CreatePlant(), UpdatePlant(), DeletePlant() */

using Sprouty.Contracts;
using Sprouty.Entities;
using Sprouty.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sprouty.Repositories
{
    /* Class: PlantRepository
     * Inherits: RepositoryBase<Plant>
     * Implements: IPlantRepository 
     * Purpose: 
     *      To provide the specific implementation of RepositoryBase for type Plant provided by the interface contract 
     *      in IPlantRepository */
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
            return FindByCondition(p => p.UserId == userId).ToList();
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
