using System.Collections.Generic;

namespace Core.Entitities
{
    public class Currency : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string HtmlCode { get; set; }

        public ICollection<HousePrice> HousePrices
        {
            get; set;
        }
    }
}