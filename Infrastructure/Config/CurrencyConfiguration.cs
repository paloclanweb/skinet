using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.Property(h => h.Id).IsRequired();

            builder.HasMany(e => e.HousePrices)
                    .WithOne(e => e.Currency)
                    .HasForeignKey(e => e.CurrencyId);
        }
    }
}