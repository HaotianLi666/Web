using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
﻿/* File: Plant.cs
 * Authors: Cameron Carley, Jonathan Wenek
 * Purpose: Model that describes the data types of each of the properties for the Plant model */

using System.ComponentModel.DataAnnotations.Schema;

namespace Sprouty.Entities.Models
{
    [Table("Plants")] // name of the collection these documents are stored in
    [BsonIgnoreExtraElements]
    public class Plant : BaseModel
    {
        [BsonElement("info")]
        string Info { get; set; }

        [BsonElement("commonName")] 
        string CommonName{ get; set; }
        
        [BsonElement("scientificName")]
        string ScientificName{ get; set; }
    }

    [BsonIgnoreExtraElements]
    public class PlantDetails: Plant
    {
        [BsonElement("givenName")]
        string GivenName { get; set; }

        [BsonElement("waterSchedule")]
        int WaterSchedule { get; set; }

        [BsonElement("lastWatered")]
        DateTime LastWatered { get; set; }

        [BsonElement("whenPlanted")]
        DateTime WhenPlanted { get; set; }

        [BsonElement("location")]
        string Location { get; set; }
    }
}
