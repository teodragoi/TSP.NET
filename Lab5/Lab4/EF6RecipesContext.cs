
using System.Data.Entity;

namespace Lab4
{
    public class EF6RecipesContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public EF6RecipesContext() : base("Server=DESKTOP-V6APB04\\MSSQLSERVER01; Database=ProductDb; Trusted_Connection=True")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .Map(m =>
                {
                    m.Properties(p => new { p.SKU, p.Description, p.Price });
                    m.ToTable("Product", "BazeDeDate");
                })
                .Map(m =>
                {
                    m.Properties(p => new { p.SKU, p.ImageUrl });
                    m.ToTable("ProductWebInfo", "BazaDeDate");
                });
        }
    }
}
