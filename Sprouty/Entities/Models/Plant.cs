/* File: Plant.cs
 * Authors: Cameron Carley, Jonathan Wenek
 * Purpose: Model that describes the data types of each of the properties for the Plant model */

using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprouty.Entities.Models
{
    [Table("Plants")] // name of the collection these documents are stored in
    [BsonIgnoreExtraElements]
    public class Plant : BaseModel
    {
        [BsonElement("givenName")] // This is the name of the JSON element in the mongodb document
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
    }
}
