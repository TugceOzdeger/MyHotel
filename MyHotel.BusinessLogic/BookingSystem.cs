using System.Linq;
using MyHotel.BusinessCommon;
using MyHotel.BusinessEntities;
using MyHotel.Common.Enums;

namespace MyHotel.BusinessLogic
{
    public class BookingSystem :IBookingSystem
    {
        public void AddGuestToBooking(Booking myBooking, Guest guest)
        {
            if (myBooking.Hotel.CountryCode == CountryEnum.De)
            {
                if (myBooking.Guests.Count(x => x.Title == null) != 0 ||
                    myBooking.Guests.Count >= (int) myBooking.RoomType) return;
                myBooking.Guests.Add(guest);
            }
            else
            {
                if (myBooking.Guests.Count < (int) myBooking.RoomType)
                    myBooking.Guests.Add(guest);
            }
        }
    }
}
