using System.ComponentModel.DataAnnotations;

namespace Sprouty.Entities.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
