using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PWEAirBnB.ViewModels
{
    public class UserVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public List<UserVM> Users { get; set; }
    }
}