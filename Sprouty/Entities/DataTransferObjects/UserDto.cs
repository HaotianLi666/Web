/* File: UserDto.cs
 * Authors: Jonathan Wenek
 * Purpose: Model that describes the data types of each of the properties for the UserDto model */

using MongoDB.Bson.Serialization.Attributes;
using Sprouty.Entities.Models;
using System;
using System.Collections.Generic;

namespace Sprouty.Entities.DataTransferObjects
{
    public class UserDto : BaseModel
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
    }
}
