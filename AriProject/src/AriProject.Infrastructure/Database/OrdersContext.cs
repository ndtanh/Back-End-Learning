using Microsoft.EntityFrameworkCore;
using AriProject.Domain.Customers;
using AriProject.Domain.Payments;
using AriProject.Domain.Products;
using AriProject.Infrastructure.Processing.InternalCommands;
using AriProject.Infrastructure.Processing.Outbox;

namespace AriProject.Infrastructure.Database
{
    public class OrdersContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OutboxMessage> OutboxMessages { get; set; }

        public DbSet<InternalCommand> InternalCommands { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public OrdersContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OrdersContext).Assembly);
        }
    }
}
