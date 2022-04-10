using System;
using MyHotel.BusinessContracts;
using MyHotel.BusinessEntities;
using MyHotel.BusinessLogic;
using MyHotel.DataAccess;

namespace MyHotel.BusinessService
{
    public class BookingService : IBookingService
    {
        public Booking FetchBooking(Guid bookingId)
        {
            var myBooking = new BookingRepository();
            return myBooking.GetMyBooking(bookingId);            
        }

        public void AddGuestToBooking(Guid bookingId, Guest guest)
        {
            var myBookingSystem = new BookingSystem();                
            myBookingSystem.AddGuestToBooking(FetchBooking(bookingId), guest);
        }
    }
}
