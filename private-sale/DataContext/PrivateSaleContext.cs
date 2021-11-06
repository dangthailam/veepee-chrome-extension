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
        public DbSet<ProductInformation> ProductInformations { get; set; }
        public DbSet<ProductLine> ProductLines { get; set; }
        public DbSet<ProductSelection> ProductSelections { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<ProductInformation>().ToTable("ProductInformation");
            modelBuilder.Entity<ProductLine>().ToTable("ProductLine");
            modelBuilder.Entity<ProductSelection>().ToTable("ProductSelection");
            modelBuilder.Entity<Sale>().ToTable("Sale");
        }
    }
}