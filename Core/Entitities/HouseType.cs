using System.Collections.Generic;

namespace Core.Entitities
{
    public class HouseType : BaseEntity
    {
        public int SortOrder { get; set; }

        public ICollection<HouseTypeLg> HouseTypeLgs
        {
            get; set;
        }
    }
}