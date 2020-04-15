using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class PropertyTypeConfiguration : IEntityTypeConfiguration<PropertyType>
    {
        public void Configure(EntityTypeBuilder<PropertyType> builder)
        {
            builder.Property(h => h.Id).IsRequired();

            builder.HasMany(e => e.PropertyTypeLgs)
                    .WithOne(e => e.PropertyType)
                    .HasForeignKey(e => e.PropertyTypeId);
        }

    }
}