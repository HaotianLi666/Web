using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprouty.Entities.Models
{   
    /*
     TODO: Implement function calls
    */
    [Table("Plants")] // name of the collection these documents are stored in
    public class Plant : BaseModel
    {
        string GivenName;

        int WaterSchedule;

        DateTime LastWatered;

        DateTime WhenPlanted;

        DateTime WhenToWaterNext => LastWatered.AddDays(WaterSchedule * 7);

        string Location;

        string CommonName;

        string ScientificName;

        int Status; //Alive or Dead? , Boolean?
   

    }
}
