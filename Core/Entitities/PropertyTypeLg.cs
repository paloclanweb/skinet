namespace Core.Entitities
{
    public class PropertyTypeLg : BaseEntity
    {
        public string Name { get; set; }
        public string Lang { get; set; }
        public PropertyType PropertyType { get; set; }
        public int PropertyTypeId { get; set; }
    }
}