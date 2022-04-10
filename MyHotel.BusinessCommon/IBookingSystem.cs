
using MyHotel.BusinessEntities;

namespace MyHotel.BusinessCommon
{
    public interface IBookingSystem
    {
        void AddGuestToBooking(Booking myBooking, Guest guest);
    }
}
