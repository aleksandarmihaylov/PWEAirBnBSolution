using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PWEAirBnB.ViewModels
{
    public class BookingVM
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        /// <summary>
        /// The selected RoomId only when saving
        /// </summary>
        public int RoomId { get; set; }
        public List<RoomVM> Rooms { get; set; }
        public List<BookingVM> Bookings { get; set; }
    }
}