using Microsoft.EntityFrameworkCore;
using Store.Core.Entities;

namespace Store.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


       public DbSet<Product> Products => Set<Product>();
       public DbSet<Category> Categories => Set<Category>();
       public DbSet<Order> Orders => Set<Order>();
       public DbSet<OrderDetail> OrderDetails => Set<OrderDetail>();
       public DbSet<Inventory> Inventories => Set<Inventory>();





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
