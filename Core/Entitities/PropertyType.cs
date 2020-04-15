using System.Collections.Generic;

namespace Core.Entitities
{
    public class PropertyType : BaseEntity
    {
        public int SortOrder { get; set; }

        public ICollection<PropertyTypeLg> PropertyTypeLgs
        {
            get; set;
        }
    }
}