using PWEAirBnB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PWEAirBnB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public  ActionResult Test()
        //{
        //    RoomVM myRoomVM = new RoomVM();
        //    myRoomVM.Name = "My Room";
        //    myRoomVM.Description = "This is my description";
        //    myRoomVM.RoomNumber = 10;
        //    return View(myRoomVM);
        //}
    }
}