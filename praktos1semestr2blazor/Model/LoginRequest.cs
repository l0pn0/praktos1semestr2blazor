using System.ComponentModel.DataAnnotations;

namespace praktos1semestr2blazor.Model
{
    public class LoginRequest
    {

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
