namespace Core.Entitities
{
    public class BuildTypeLg : BaseEntity
    {
        public string Name { get; set; }
        public string Lang { get; set; }
        public BuildType BuildType { get; set; }
        public int BuildTypeId { get; set; }
    }
}