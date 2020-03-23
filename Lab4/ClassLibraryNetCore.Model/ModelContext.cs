using Microsoft.EntityFrameworkCore;

namespace ClassLibraryNetCore.Model
{
    public class ModelContext : DbContext 
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-V6APB04\\MSSQLSERVER01; Database=EfCore2020; Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany<Order>(o => o.Orders)
                .WithOne(c => c.Client);

            modelBuilder.Entity<Order>()
                .HasOne<OrderDetails>(o => o.OrderDetails)
                .WithOne(od => od.Order);

            modelBuilder.Entity<OrderDetails>()
                .HasOne<Order>(od => od.Order)
                .WithOne(o => o.OrderDetails);

            modelBuilder.Entity<OrderDetails>()
                .HasMany<Product>(od => od.Products)
                .WithOne(p => p.OrderDetails);
        }
    }
}
