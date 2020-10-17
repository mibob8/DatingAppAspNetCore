using System.ComponentModel.DataAnnotations;

namespace PortalRandkowy.API.Dtos
{
    public class UserDto
    {
        [Required(ErrorMessage = "Nazwa wymagana")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Hasło jest wymagane")]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "Za krótkie hasło")]
        public string Password { get; set; }

    }
}