using System.Collections.Generic;

namespace Core.Entitities
{
    public class BuildType: BaseEntity
    {
        public int SortOrder { get; set; }
        public ICollection<BuildTypeLg> BuildTypeLgs
        {
            get; set;
        }
    }
}