namespace Core.Entitities
{
    public class HouseLg : BaseEntity
    {
        public string Description { get; set; }
        public string Lang { get; set; }
        public House House { get; set; }
        public int HouseId { get; set; }
    }
}