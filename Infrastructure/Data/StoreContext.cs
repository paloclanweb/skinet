using System.Reflection;
using Core.Entitities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<House> Houses { get; set; }
        public DbSet<HouseType> HouseTypes { get; set; }
        public DbSet<HouseTypeLg> HouseTypeLgs { get; set; }
        public DbSet<BuildType> BuildTypes { get; set; }
        public DbSet<BuildTypeLg> BuildTypesLgs { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<PropertyTypeLg> PropertyTypeLgs { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<HouseDestinationLg> HouseDestinationLgs { get; set; }
        public DbSet<HouseLg> HouseLgs { get; set; }
        public DbSet<HousePhoto> HousePhotos { get; set; }
        public DbSet<HousePrice> HousePrices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}