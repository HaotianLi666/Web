﻿using MongoDB.Bson.Serialization.Attributes;
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
        // TODO : add UserDto properties

        string UserId { get; set; }

        string EmailAddress { get; set; }

        ICollection<Plant> UserPlants { get; set; }

        DateTime LastLoggedIn { get; set; }

        DateTime AccountCreated
        {
            get { return AccountCreated; }
            set { throw new NotSupportedException("Initialized in Constructor"); } //Perhaps to early to implement this?
        }
    }
}
