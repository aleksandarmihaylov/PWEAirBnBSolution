using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PWEAirBnB.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int RoomId { get; set; }
    }
}