using PWEAirBnB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PWEAirBnB.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        public ActionResult Index()
        {
            RoomVM myRoom = new RoomVM();
            myRoom.Name = "My new room";
            myRoom.Description = "This is my room description";
            myRoom.RoomNumber = 1;
            return View(myRoom);
        }

        //GET: Room/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST: Room/Create
        [HttpPost]
        public ActionResult Create(RoomVM model)
        {
            return RedirectToAction("Index");
        }

    }
}