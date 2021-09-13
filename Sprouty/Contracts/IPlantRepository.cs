using Sprouty.Entities.Models;
using System.Collections.Generic;

namespace Sprouty.Contracts
{
    public interface IPlantRepository
    {
        IEnumerable<Plant> GetAll();
        Plant GetPlantById(string id);

        // TODO : add the rest of the interface functions, see UML
    }
}
