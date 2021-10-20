/* File: User.cs
 * Authors: Cameron Carley, Jonathan Wenek
 * Purpose: Model that describes the data types of each of the properties for the User model */
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Sprouty.Entities.Models
{
    [Table("Users")] // name of the collection these documents are stored in
    [BsonIgnoreExtraElements]
    public class User: BaseModel
    {
        [BsonElement("userId")] // the users account name
        public string UserId { get; set; }

        [BsonElement("emailAddress")] // users email address
        public string EmailAddress { get; set; }

        [JsonIgnore]
        [BsonElement("password")] // users hashed password
        public string Password { get; set; }

        [JsonIgnore]
        [BsonElement("salt")] // salt for password hashing
        public string Salt { get; set; }

        [BsonElement("plants")] // collection of the users plants
        public ICollection<Plant> Plants { get; set; } 
    }
}
