namespace XeonFun.Entites.Models
{
    public class UserPhoto : BaseEntity
    {
        byte[] photo { get; set; }
        DateTime created { get; set; }
        bool isDeleted { get; set; }

        public long UserId { get; set; }
        public virtual User User { get; set; } 
    }
}
