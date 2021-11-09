using Microsoft.EntityFrameworkCore;
using PrivateSale.Models;

namespace PrivateSale.DataContext
{
    public class PrivateSaleContext : DbContext
    {
        public PrivateSaleContext(DbContextOptions<PrivateSaleContext> options) : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductInformation> ProductInformations { get; set; }
        public DbSet<ProductLine> ProductLines { get; set; }
        public DbSet<ProductSelection> ProductSelections { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SaleEntityTypeConfiguration());
            modelBuilder.Entity<ProductInformation>().ToTable("ProductInformation").HasKey(x => x.Id);
            modelBuilder.Entity<ProductLine>().ToTable("ProductLine").HasKey(x => x.Id);
            modelBuilder.Entity<ProductSelection>().ToTable("ProductSelection").HasKey(x => x.Id);
        }
    }
}