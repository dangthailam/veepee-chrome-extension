using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrivateSale.Models;

namespace PrivateSale.DataContext
{
    public class SaleEntityTypeConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(x => x.Id);
            builder.OwnsOne(x => x.SalePeriod)
                .Property(x => x.StartAt)
                .HasColumnName("StartAt");
            builder.OwnsOne(x => x.SalePeriod)
                .Property(x => x.EndAt)
                .HasColumnName("EndAt");
        }
    }
}