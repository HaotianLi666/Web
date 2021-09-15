using Sprouty.Entities.Models;
using System.Collections.Generic;

namespace Sprouty.Contracts
{
    public interface IPlantRepository
    {
        IEnumerable<Plant> GetAll();
        Plant GetPlantById(string id);
        void CreatePlant(Plant plant);
        void UpdatePlant(string id, Plant plant);
        void DeleteClient(string id);
    }
}
