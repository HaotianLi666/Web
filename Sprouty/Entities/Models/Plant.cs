using MongoDB.Bson;
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

        string GivenName{ get; set; }
  
        int WaterSchedule{ get; set; }

        DateTime LastWatered{ get; set; }

        DateTime WhenPlanted{ get; set; }

        DateTime WhenToWaterNext => LastWatered.AddDays(WaterSchedule * 7);

        string Location{ get; set; }

        string CommonName{ get; set; }

        string ScientificName{ get; set; }

        int Status { get; set; }//Alive or Dead? , Boolean?


        public Guid UserId { get; set; }
        public User User{get; set;}
    }
}
