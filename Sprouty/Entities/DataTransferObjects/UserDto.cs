/* File: UserDto.cs
 * Authors: Jonathan Wenek
 * Purpose: Model that describes the data types of each of the properties for the UserDto model */

using MongoDB.Bson.Serialization.Attributes;
using Sprouty.Entities.Models;
using System.Collections.Generic;

/** DTO's are files used JUST for data transfer. This is what will be mapped to the Database. */
namespace Sprouty.Entities.DataTransferObjects
{
    [BsonIgnoreExtraElements]
    public class UserDto : BaseModel
    {
        [BsonElement("userId")]
        public string UserId { get; set; }

        [BsonElement("emailAddress")]
        public string EmailAddress { get; set; }

        [BsonElement("plants")]
        public ICollection<Plant> Plants { get; set; }
    }
}
