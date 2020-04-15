namespace Core.Entitities
{
    public class HouseDestinationLg : BaseEntity
    {
        public string Name { get; set; }
        public string Lang { get; set; }
        public House House { get; set; }
        public int HouseId { get; set; }
    }
}