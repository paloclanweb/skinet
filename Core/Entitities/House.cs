using System;
using System.Collections.Generic;

namespace Core.Entitities
{
    public class House : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Rooms { get; set; }
        public int Disabled { get; set; }
        public int MaxGuests { get; set; }
        public int SinglesRooms { get; set; }
        public int DoublesRooms { get; set; }
        public int TripleRooms { get; set; }
        public int BathRooms { get; set; }
        public string Email { get; set; }
        public string CheckinFrom { get; set; }
        public string CheckinTo { get; set; }
        public string CheckoutUntil { get; set; }
        public string CancellationPolicy { get; set; }
        public int SortOrder { get; set; }
        public string PictureUrl { get; set; }
        public HouseType HouseType { get; set; } // esta es AlojType
        public int HouseTypeId { get; set; }
        public BuildType BuildType { get; set; } // esta es AlojType
        public int BuildTypeId { get; set; }
        public PropertyType PropertyType { get; set; }
        public int PropertyTypeId { get; set; }
        public ICollection<HouseLg> HouseLgs
        {
            get; set;
        }
        public ICollection<HousePrice> HousePrices
        {
            get; set;
        }
        public ICollection<HousePhoto> HousePhotos
        {
            get; set;
        }
        public ICollection<HouseDestinationLg> HouseDestinationLgs
        {
            get; set;
        }
    }
}