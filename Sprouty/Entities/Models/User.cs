using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprouty.Entities.Models
{
    [Table("Users")] // name of the collection these documents are stored in
    public class User : BaseModel
    {
        // TODO : Add User properties
    }
}
