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
