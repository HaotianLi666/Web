using System.Collections.Generic;

namespace Sprouty.Entities.Models
{
    public class AuthenticateResponse : BaseModel
    {
        public string UserId { get; set; }
        public string EmailAddress { get; set; }
        public string Token { get; set; }
        public ICollection<Plant> Plants { get; set; }

        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            UserId = user.UserId;
            EmailAddress = user.EmailAddress;
            Plants = user.Plants;
            Token = token;
        }
    }
}
