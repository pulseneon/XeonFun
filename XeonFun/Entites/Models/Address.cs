namespace XeonFun.Entites.Models
{
    public class Address : BaseEntity
    {
        public string District { get; set; } // район
        public string City { get; set; } // город
        public string Street { get; set; } // улица 
        public string HouseNumber { get; set; } // номер дома
        public string Index { get; set; } // индекс
        public bool isDelete { get; set; } = false;
        public long UserID { get; set; }
        public virtual User User { get; set; }
    }
}
