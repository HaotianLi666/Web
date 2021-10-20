/* File: MappingProfile.cs
 * Authors: Jonathan Wenek
 * Purpose: To provide a named configuration for maps between User and Plant and their respective data transfer objects */

using AutoMapper;
using Sprouty.Entities.DataTransferObjects;
using Sprouty.Entities.Models;

namespace Sprouty
{
    /* Class: MappingProfile
     * Inherits: Profile
     * Purpose: To configure all maps needed for the AutoMapper which will be utilized through dependancy injection */
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<NewUserDto, User>();
            CreateMap<Plant, PlantDto>();
            CreateMap<PlantDto, Plant>();
        }
    }
}
