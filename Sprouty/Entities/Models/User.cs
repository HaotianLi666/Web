using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprouty.Entities.Models
{
    [Table("Users")] // name of the collection these documents are stored in
    public class User : BaseModel
    {
        string UserId { get; set; }

        string EmailAddress { get; set; }

        ICollection<Plant> UserPlants { get; set; }

        DateTime LastLoggedIn { get; set;}

        DateTime AccountCreated {
            get { return AccountCreated; }
            set { throw new NotSupportedException("Initialized in Constructor"); } //Perhaps to early to implement this?



        /*TODO : Create user settings*/
        /*UserSettings Settings;*/
    
        
    
    }   
}
