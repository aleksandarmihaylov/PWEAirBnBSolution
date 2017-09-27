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
            return View();
        }
    }
}