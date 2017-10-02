using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PWEAirBnB.ViewModels
{
    public class RoomVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RoomNumber { get; set; }
        public bool IsOccupied { get; set; }

        public List<RoomVM> Rooms { get; set; }
    }
}