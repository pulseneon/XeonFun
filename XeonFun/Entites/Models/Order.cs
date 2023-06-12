using XeonFun.Entites.Enums;

namespace XeonFun.Entites.Models
{
    public class Order : BaseEntity
    {
        public Status Status { get; set; }
        public string Comment { get; set; }
        public uint Count { get; set; }
        public DateTime created { get; set; }
        public DateTime? completionDate { get; set; } = null;

        public long UserId { get; set; }
        public virtual User User { get; set; }

        public int AddressId { get; set; } 
        public virtual Address Address { get; set; }
    }
}
