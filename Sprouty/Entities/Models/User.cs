/* File: User.cs
 * Authors: Cameron Carley, Jonathan Wenek
 * Purpose: Model that describes the data types of each of the properties for the User model */

using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprouty.Entities.Models
{
    [Table("Users")] // name of the collection these documents are stored in
    [BsonIgnoreExtraElements]
    public class User : BaseModel
    {
        [BsonElement("userId")]
        public string UserId { get; set; }

        [BsonElement("emailAddress")]
        public string EmailAddress { get; set; }

        [BsonElement("settings")]
        public UserSettings Settings { get; set; }

        [BsonElement("userPlants")]
        public ICollection<Plant> UserPlants { get; set; }

        [BsonElement("lastLoggedIn")]
        public DateTime LastLoggedIn { get; set; }
         [BsonElement("accountCreated")]
        DateTime AccountCreated
        {
            get { return AccountCreated; }
            set { throw new NotSupportedException("Initialized in Constructor"); } //Perhaps to early to implement this?
        }
    }
}
