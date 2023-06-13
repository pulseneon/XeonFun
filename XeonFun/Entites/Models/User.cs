using System.Text.Json.Serialization;
using XeonFun.Entites.Enums;

namespace XeonFun.Entites.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string Username { get; set; }
        public string? Email { get; set; }
        public bool EmailConfirmed { get; set; } = false;
        public string Password { get; set; }
        public string? Phone { get; set; }
        public bool PhoneConfirmed { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public DateTime Created { get; set; } = DateTime.Now.ToUniversalTime();
        public Role Role { get; set; } = Role.User;

        public virtual UserPhoto? Photo { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Address> Addreses { get; set; }
        public virtual ICollection<CreditCard> CreditCards { get; set; }
    }
}
