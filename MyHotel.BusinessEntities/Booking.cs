using System.Collections.Generic;
using MyHotel.Common.Enums;

namespace MyHotel.BusinessEntities
{
    public class Booking
    {
        public List<Guest> Guests { get; set; } //It is implemented as List not IEnumerable so that I can add a new guest and be able to verify it via unit tests
        public RoomTypeEnum RoomType { get; set; }
        public Hotel Hotel { get; set; }
    }
}
