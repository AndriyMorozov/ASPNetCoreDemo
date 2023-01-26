using Microsoft.EntityFrameworkCore;
using WebApplication4.Models.Menu;
using WebApplication4.Models.Shop;

namespace WebApplication4.Data
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Item> Menu { set; get; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public ShopDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
