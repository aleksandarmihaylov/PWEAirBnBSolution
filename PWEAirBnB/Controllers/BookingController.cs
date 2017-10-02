using PWEAirBnB.DAL;
using PWEAirBnB.Models;
using PWEAirBnB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PWEAirBnB.Controllers
{
    public class BookingController : Controller
    {
        //This is going to be my Booking controller
        // GET: Booking
        public ActionResult Index()
        {
            RoomRepository roomRepository = new RoomRepository();
            List<Room> rooms = roomRepository.LoadAllRooms();
            List<RoomVM> roomVMs = new List<RoomVM>();

            foreach (Room room in rooms)
            {
                RoomVM rvm = new RoomVM();
                {
                    rvm.Description = room.Description;
                    rvm.Id = room.Id;
                    rvm.IsOccupied = false; // needs to be set from the database
                    rvm.Name = room.Name;
                    rvm.RoomNumber = room.RoomNumber;
                    //add it to the list
                    roomVMs.Add(rvm);
                }
            }
            //load all bookings 
            BookingRepository bookingRepository = new BookingRepository();
            List<Booking> bookings = bookingRepository.LoadAllBookings();
            List<BookingVM> bookingVMs = new List<BookingVM>();
            foreach (Booking booking in bookings)
            {
                BookingVM bvm = new BookingVM();
                bvm.StartTime = booking.StartTime;
                bvm.EndTime = booking.EndTime;
                bvm.RoomId = booking.RoomId;
                bookingVMs.Add(bvm);
            }
            BookingVM model = new BookingVM();
            model.Rooms = roomVMs;
            model.Bookings = bookingVMs;

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            string startDate = collection["StartTime"];
            string endDate = collection["EndTime"];
            int roomId = int.Parse(collection["RoomId"]);
            //create booking
            Booking booking = new Booking();
            booking.RoomId = roomId;
            booking.StartTime = DateTime.Parse(startDate);
            booking.EndTime = DateTime.Parse(endDate);
            //create the repository
            BookingRepository bookingRepository = new BookingRepository();
            bookingRepository.SaveBooking(booking);
            //return
            return RedirectToAction("Index", "Booking");
        }
    }
}