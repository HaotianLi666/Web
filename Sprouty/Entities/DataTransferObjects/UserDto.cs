/* File: UserDto.cs
 * Authors: Jonathan Wenek
 * Purpose: Model that describes the data types of each of the properties for the UserDto model */

using MongoDB.Bson.Serialization.Attributes;
using Sprouty.Entities.Models;
using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;



/**
 * DTO's are files used JUST for data transfer. This is what will be mapped to the Database.
 */

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


        [BsonElement("accountCreated")]
        DateTime AccountCreated
        {
            get { return AccountCreated; }
            set { throw new NotSupportedException("Initialized in Constructor"); } //Perhaps to early to implement this?
        }

    }
}
