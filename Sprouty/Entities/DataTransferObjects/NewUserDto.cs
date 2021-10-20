/* File: UserDto.cs
 * Authors: Jonathan Wenek
 * Purpose: Model that describes the data types of each of the properties for the UserDto model */

using MongoDB.Bson.Serialization.Attributes;
using Sprouty.Entities.Models;

/** DTO's are files used JUST for data transfer. This is what will be mapped to the Database. */
namespace Sprouty.Entities.DataTransferObjects
{
    public class NewUserDto : BaseModel
    {
        [BsonElement("userId")]
        public string UserId { get; set; }

        [BsonElement("emailAddress")]
        public string EmailAddress { get; set; }

        [BsonElement("password")]
        public string password { get; set; }

    }
}
