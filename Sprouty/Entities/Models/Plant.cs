using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprouty.Entities.Models
{
    [Table("Plants")] // name of the collection these documents are stored in
    public class Plant : BaseModel
    {
        // TODO : Add Plant properties
    }
}
