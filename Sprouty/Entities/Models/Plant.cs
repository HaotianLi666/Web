using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
﻿/* File: Plant.cs
 * Authors: Cameron Carley, Jonathan Wenek
 * Purpose: Model that describes the data types of each of the properties for the Plant model */

using System.ComponentModel.DataAnnotations.Schema;

namespace Sprouty.Entities.Models
{
    /*
     TODO: Implement function calls
    */
    [Table("Plants")] // name of the collection these documents are stored in
    [BsonIgnoreExtraElements]
    public class Plant : BaseModel
    {
        [BsonElement("givenName")] 
        string GivenName{ get; set; }
        [BsonElement("waterSchedule")]
        int WaterSchedule{ get; set; }
        [BsonElement("lastWatered")]
        DateTime LastWatered{ get; set; }
        [BsonElement("whenPlanted")]
        DateTime WhenPlanted{ get; set; }
        [BsonElement("whenToWaterNext")]
        DateTime WhenToWaterNext => LastWatered.AddDays(WaterSchedule * 7);
        [BsonElement("location")]
        string Location{ get; set; }
        [BsonElement("commonName")] 
        string CommonName{ get; set; }
        
        [BsonElement("scientificName")]
        string ScientificName{ get; set; }
        [BsonElement("status")]
        int Status { get; set; }//Alive or Dead? , Boolean?


        public Guid UserId { get; set; }
        public User User{get; set;}
    }
}
