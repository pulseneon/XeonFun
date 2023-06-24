using Microsoft.EntityFrameworkCore;
using XeonFun.Entites.Models;
using XeonFun.Entites.Models.Products;

namespace XeonFun.Data
{
    public class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; } 
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CreditCard> Cards { get; set; }
        public DbSet<UserPhoto> UserPhotos { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Videocard> Videocards { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
