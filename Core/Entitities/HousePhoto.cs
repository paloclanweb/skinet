namespace Core.Entitities
{
    public class HousePhoto : BaseEntity
    {
        public string PhotoUrl { get; set; }
        public string ThumbUrl { get; set; }
        public House House { get; set; }
        public int HouseId { get; set; }
    }
}