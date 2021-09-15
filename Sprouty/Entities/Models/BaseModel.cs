/* File: BaseModel.cs
 * Authors: Jonathan Wenek
 * Purpose: This is the base model from which User and Plant are derived */

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Sprouty.Entities.Models
{
    public class BaseModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
