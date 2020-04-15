namespace Core.Entitities
{
    public class HouseTypeLg : BaseEntity
    {
        public string Name { get; set; }
        public string Lang { get; set; }
        public HouseType HouseType { get; set; }
        public int HouseTypeId { get; set; }
    }
}