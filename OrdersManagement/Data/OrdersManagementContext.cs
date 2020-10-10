using Microsoft.EntityFrameworkCore;
using OrdersManagement.Models;

namespace OrdersManagement.Data
{
    public class OrdersManagementContext : DbContext
    {
        public OrdersManagementContext(DbContextOptions<OrdersManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().HasKey(od => new { od.OrderId, od.ProductId });
        }
    }
}
