/* File: PlantDto.cs
 * Authors: Jonathan Wenek
 * Purpose: Model that describes the data types of each of the properties for the PlantDto model */

using MongoDB.Bson.Serialization.Attributes;
using Sprouty.Entities.Models;

using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sprouty.Entities.DataTransferObjects
{
    public class PlantDto : BaseModel
    {


        [BsonElement("lastWatered")]
        DateTime LastWatered;
        [BsonElement("whenPlanted")]
        DateTime WhenPlanted;
        [BsonElement("givenName")]
        public string GivenName { get; set; }

        [BsonElement("commonName")]
        public string CommonName { get; set; }

        [BsonElement("scientificName")]
        public string ScientificName { get; set; }

        [BsonElement("waterSchedule")]
        public int WaterSchedule { get; set; }

        [BsonElement("location")]
        public string Location { get; set; }

        [BsonElement("status")]
        public int Status { get; set; }


        [BsonElement("userId")]
        public Guid UserId { get; set; }
        [BsonElement("user")]
        public User User { get; set; }

    }
}
