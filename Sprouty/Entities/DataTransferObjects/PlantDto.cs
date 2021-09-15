/* File: PlantDto.cs
 * Authors: Jonathan Wenek
 * Purpose: Model that describes the data types of each of the properties for the PlantDto model */

using MongoDB.Bson.Serialization.Attributes;
using Sprouty.Entities.Models;
<<<<<<< HEAD
using System;
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> master

namespace Sprouty.Entities.DataTransferObjects
{
    public class PlantDto : BaseModel
    {
<<<<<<< HEAD
        string GivenName;

        int WaterSchedule;

        DateTime LastWatered;

        DateTime WhenPlanted;

        string Location;

        string CommonName;

        string ScientificName;

        int Status; //Alive or Dead? , Boolean?

=======
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
>>>>>>> master
    }
}
