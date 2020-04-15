using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class HouseConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder.Property(h => h.Id).IsRequired();
            builder.Property(h => h.Name).IsRequired().HasMaxLength(100);
            builder.Property(h => h.Address).HasMaxLength(200);
            builder.Property(h => h.Email).HasMaxLength(50);
            builder.Property(h => h.Latitude).IsRequired();
            builder.Property(h => h.Longitude).IsRequired();
            builder.Property(h => h.Disabled).IsRequired();
            builder.Property(h => h.Rooms).IsRequired();
            builder.Property(h => h.MaxGuests).IsRequired();
            builder.Property(h => h.SinglesRooms).IsRequired();
            builder.Property(h => h.DoublesRooms).IsRequired();
            builder.Property(h => h.TripleRooms).IsRequired();
            builder.Property(h => h.BathRooms).IsRequired();
            // builder.Property(h => h.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(h => h.PictureUrl).IsRequired();
                
            builder.HasOne(t => t.HouseType).WithMany()
                .HasForeignKey(h => h.HouseTypeId);

            builder.HasOne(t => t.BuildType).WithMany()
                .HasForeignKey(h => h.BuildTypeId);

            builder.HasOne(t => t.PropertyType).WithMany()
                .HasForeignKey(h => h.PropertyTypeId);

            builder.HasMany(e => e.HouseLgs)
                .WithOne(e => e.House)
                .HasForeignKey(e => e.HouseId);

            builder.HasMany(e => e.HousePrices)
                .WithOne(e => e.House)
                .HasForeignKey(e => e.HouseId);

            builder.HasMany(e => e.HousePhotos)
                .WithOne(e => e.House)
                .HasForeignKey(e => e.HouseId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.HouseDestinationLgs)
                .WithOne(e => e.House)
                .HasForeignKey(e => e.HouseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}