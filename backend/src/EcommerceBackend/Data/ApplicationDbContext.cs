using Microsoft.EntityFrameworkCore;
using EcommerceBackend.Core.Models;

namespace EcommerceBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DbSet for your models/entities
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Product Entity (optional)
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);  // Define the primary key if not already defined in the model
                
                entity.Property(p => p.Price)
                      .HasPrecision(18, 2);  // Define precision for decimal fields (18 digits, 2 after the decimal point)
            });

            // Seed initial data
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Sample Product 1", Price = 10.99m, Description = "This is a sample product" },
                new Product { Id = 2, Name = "Sample Product 2", Price = 20.99m, Description = "This is another sample product" }
            );
        }
    }
}