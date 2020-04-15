using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class HouseTypeConfiguration : IEntityTypeConfiguration<HouseType>
    {
        public void Configure(EntityTypeBuilder<HouseType> builder)
        {
            builder.Property(h => h.Id).IsRequired();

            builder.HasMany(e => e.HouseTypeLgs)
                    .WithOne(e => e.HouseType)
                    .HasForeignKey(e => e.HouseTypeId);
        }
       
    }
}