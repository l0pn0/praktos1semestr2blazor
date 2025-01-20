using System.ComponentModel.DataAnnotations;

namespace praktos1semestr2blazor.Model
{
    public class User
    {
        [Key]
        public int id_User { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}

