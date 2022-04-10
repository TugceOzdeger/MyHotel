using System;
using MyHotel.BusinessEntities;

namespace MyHotel.BusinessContracts
{
    public interface IBookingService
    {
        Booking FetchBooking(Guid bookingId);
        void AddGuestToBooking(Guid bookingId, Guest guest);
    }
}
