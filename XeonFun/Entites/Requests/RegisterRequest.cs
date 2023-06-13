using System.ComponentModel.DataAnnotations;

namespace XeonFun.Entites.Requests
{
    public class RegisterRequest
    {
        [Required, MinLength(3), MaxLength(25)]
        public string FirstName { get; set; }

        [Required, MinLength(3), MaxLength(25)]
        public string LastName { get; set; } = string.Empty;

        [Required, MinLength(3), MaxLength(25)]
        public string Username { get; set; }

        [Required, MinLength(3), MaxLength(25)]
        public string Password { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
