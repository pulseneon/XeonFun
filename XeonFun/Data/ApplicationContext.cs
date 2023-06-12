using Microsoft.EntityFrameworkCore;
using XeonFun.Entites.Models;

namespace XeonFun.Data
{
    public class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; } 
        public DbSet<Order> Order { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
