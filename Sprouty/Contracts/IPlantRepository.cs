/* File: IPlantRepository.cs
 * Authors: Jonathan Wenek
 * Purpose: Public interface of the plant repository
 * Functions: GetAll(), GetPlantById(), CreatePlant(), UpdatePlant(), DeletePlant() */
using Sprouty.Entities.Models;
using System;
using System.Collections.Generic;

namespace Sprouty.Contracts
{
    /* Interface: IPlantRepository
     * Purpose: Defines the functions which must be implemented by any class which implements this interface */
    public interface IPlantRepository
    {
        IEnumerable<Plant> GetAllPlants();
        Plant GetPlantById(string id);
        void CreatePlant(Plant plant);
        void UpdatePlantWithId(string id, Plant plant);
        void DeletePlant(string id);

        void UpdatePlantWithoutId(Plant plant);

        IEnumerable<Plant> GetPlantsByUserId(Guid userId);
    }
}
