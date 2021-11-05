using Microsoft.EntityFrameworkCore;
using PrivateSale.Models;

namespace PrivateSale.DataContext
{
    public class PrivateSaleContext : DbContext
    {
        public PrivateSaleContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Product>().ToTable("Product");
        }
    }
}