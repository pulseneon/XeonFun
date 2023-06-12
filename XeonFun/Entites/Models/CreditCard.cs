namespace XeonFun.Entites.Models
{
    public class CreditCard : BaseEntity
    {
        public string Number { get; set; }
        public string OwnerName { get; set; }
        public DateTime ValidTime { get; set; }
        public string CVV { get; set; }

        public long UserId { get; set; }
        public virtual User User { get; set; }
    }
}
