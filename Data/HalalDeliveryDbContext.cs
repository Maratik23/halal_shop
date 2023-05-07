using Microsoft.EntityFrameworkCore;
using HalalDelivery.Models;

namespace HalalDelivery.Data
{
    public class HalalDeliveryDbContext : DbContext
    {
        public HalalDeliveryDbContext(DbContextOptions<HalalDeliveryDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Hala> Halals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AdditionalProduct> AdditionalProducts { get; set; }
        
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        
        public DbSet<Order> Orders { get; set; }
    }
}