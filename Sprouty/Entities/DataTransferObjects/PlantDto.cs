using MongoDB.Bson.Serialization.Attributes;
using Sprouty.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprouty.Entities.DataTransferObjects
{
    public class PlantDto : BaseModel
    {
        string GivenName;

        int WaterSchedule;

        DateTime LastWatered;

        DateTime WhenPlanted;

        string Location;

        string CommonName;

        string ScientificName;

        int Status; //Alive or Dead? , Boolean?

    }
}
