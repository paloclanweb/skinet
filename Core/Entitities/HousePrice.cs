using System;
using System.Collections.Generic;

namespace Core.Entitities
{
    public class HousePrice : BaseEntity
    {
        public DateTime SeasonStartDate { get; set; }
        public DateTime SeasonEndDate { get; set; }
        public double AllPropertyPrice { get; set; }
        public double ShareSingleRoomPrice { get; set; }
        public double ShareDoubleRoomPrice { get; set; }
        public double ShareTripleRoomPrice { get; set; }
        public House House { get; set; }
        public int HouseId { get; set; }
        public Currency Currency { get; set; }
        public int CurrencyId { get; set; }
    }
}