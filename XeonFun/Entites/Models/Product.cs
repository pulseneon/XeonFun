namespace XeonFun.Entites.Models
{
    public class Product: BaseEntity
    {
        public decimal Price { get; set; }
        public decimal? Discount { get; set; } = null; // скидка 
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Country { get; set; } // страна производитель
        public int? Warranty { get; set; } = 12; // гарантия товара
        public string ManufactureCode { get; set; } // код товара производетеля
        public string? Color { get; set; }
        public int Orders { get; set; } = 0;
        public int Stock { get; set; } = 0;

        // todo: photos
        // todo: reviiews
    }
}
