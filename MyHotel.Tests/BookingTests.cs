using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyHotel.BusinessEntities;
using MyHotel.BusinessLogic;
using MyHotel.Common.Enums;


namespace MyHotel.Tests
{
    [TestClass]
    public class BookingTests
    {
        private Booking FillDataSweden()
        {
            return
                new Booking
                {
                    Guests = new List<Guest>
                    {
                        new Guest
                        {
                            FirstName = "Linda",
                            LastName = "Nilsson",
                            Title = null
                        },
                        new Guest
                        {
                            FirstName = "Martin",
                            LastName = "Holmberg",
                            Title = null
                        }
                    },
                    Hotel = new Hotel
                    {
                        Name = "Scandic Sweden",
                        CountryCode = CountryEnum.Se
                    },
                    RoomType = RoomTypeEnum.Triple
                };
        }

        private Booking FillDataDenmark()
        {
            return
                new Booking
                {
                    Guests = new List<Guest>
                    {
                        new Guest
                        {
                            FirstName = "Andreas",
                            LastName = "Hilding",
                            Title = null
                        },
                        new Guest
                        {
                            FirstName = "Julia",
                            LastName = "Karlsson",
                            Title = null
                        }
                    },
                    Hotel = new Hotel
                    {
                        Name = "Scandic Denmark",
                        CountryCode = CountryEnum.Dk
                    },
                    RoomType = RoomTypeEnum.Twin
                };
        }

        private Booking FillDataGermany()
        {
            return                
                new Booking
                {
                    Guests = new List<Guest>
                    {
                        new Guest
                        {
                            FirstName = "Karoline",
                            LastName = "Karman",
                            Title = null
                        },

                        new Guest
                        {
                            FirstName = "David",
                            LastName = "Andersson",
                            Title = null
                        }
                    },
                    Hotel = new Hotel
                    {
                        Name = "Scandic Germany",
                        CountryCode = CountryEnum.De
                    },
                    RoomType = RoomTypeEnum.Double
                };
        }

        private static Guest AddNewGuest()
        {
            var guest = new Guest
            {
                FirstName = "Emma",
                LastName = "Bengtsson",
                Title = ""
            };
            return guest;
        }

        [TestMethod]
        public void WhenHotelCountryIsGermany_AndGuestTitleIsEmpty_ThenNewGuestCannotBeAdded()
        {
            var sut= new BookingSystem();
            var myBooking = FillDataGermany();
            sut.AddGuestToBooking(myBooking, AddNewGuest());

            Assert.AreEqual(myBooking.Guests.Count, 2);
        }

        [TestMethod]
        public void WhenHotelCountryIsNotGermany_AndGuestTitleIsEmpty_ThenNewGuestCanBeAdded()
        {
            var sut = new BookingSystem();
            var myBooking = FillDataSweden();
            sut.AddGuestToBooking(myBooking, AddNewGuest());

            Assert.AreEqual(myBooking.Guests.Count, 3);
        }

        [TestMethod]
        public void WhenThereIsEnoughBed_ThenNewGuestCanBeAdded()
        {
            var sut = new BookingSystem();
            var myBooking = FillDataSweden();
            sut.AddGuestToBooking(myBooking, AddNewGuest());

            Assert.AreEqual(myBooking.Guests.Count, 3);
        }

        [TestMethod]
        public void WhenThereIsNotEnoughBed_ThenNewGuestCannotBeAdded()
        {
            var sut = new BookingSystem();
            var myBooking = FillDataDenmark();
            sut.AddGuestToBooking(myBooking, AddNewGuest());

            Assert.AreEqual(myBooking.Guests.Count, 2);
        }
    }
}
