using demo.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace demo.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Drink> Drinks{get; set;}
        public DbSet<Category> Categories{get; set;}
        public DbSet<ShoppingCartItem> ShoppingCartItems{get; set;}
        public DbSet<Order> Orders{get; set;}
        public DbSet<OrderDetail> OrderDetails{get; set;}
    }
}