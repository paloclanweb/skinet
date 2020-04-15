using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class BuildTypeConfiguration : IEntityTypeConfiguration<BuildType>
    {
        public void Configure(EntityTypeBuilder<BuildType> builder)
        {
            builder.Property(h => h.Id).IsRequired();

            builder.HasMany(e => e.BuildTypeLgs)
                    .WithOne(e => e.BuildType)
                    .HasForeignKey(e => e.BuildTypeId);
        }

    }
}