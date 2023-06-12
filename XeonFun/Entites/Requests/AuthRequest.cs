using System.ComponentModel.DataAnnotations;

namespace XeonFun.Entites.Requests
{
    public class AuthRequest
    {
        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
