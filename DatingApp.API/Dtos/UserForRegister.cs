using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {   
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(10, MinimumLength=2, ErrorMessage="minimimim lenght")]
        public string Password { get; set; }
    }
}