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
    public class RoomController : Controller
    {
        // GET: Room
        public ActionResult Index()
        {
            //1. Create a RoomRepository for loading the data
            RoomRepository roomRepository = new RoomRepository();
            //2. Get a list of rooms
            List<Room> rooms = roomRepository.LoadAllRooms();
            //3. Translate each room into a RoomVM
            List<RoomVM> roomVMs = new List<RoomVM>();
            foreach (Room room in rooms)
            {
                //create the actual translation
                RoomVM roomvm = new RoomVM();
                roomvm.Id = room.Id;
                roomvm.Name = room.Name;
                roomvm.Description = room.Description;
                roomvm.RoomNumber = room.RoomNumber;
                //add it to the list
                roomVMs.Add(roomvm);
            }
            //4. Send it back to the view
            RoomVM model = new RoomVM();
            model.Rooms = roomVMs;
            return View(model);
        }

        //GET: Room/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            //1: Create a repository
            RoomRepository roomRepository = new RoomRepository();
            //2. Load a single Room
            Room room = roomRepository.LoadRoom(id);
            //3. Translate it to RoomVM
            RoomVM model = new RoomVM();
            model.Id = room.Id;
            model.Name = room.Name;
            model.Description = room.Description;
            model.RoomNumber = room.RoomNumber;
            //4. Send the RoomVM back to the view
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(RoomVM model)
        {
            //1. Create a Room object from the RoomVM
            Room room = new Room();
            room.Id = model.Id;
            room.Name = model.Name;
            room.Description = model.Description;
            room.RoomNumber = model.RoomNumber;
            //2. Create a RoomRepository for updating
            RoomRepository roomRepository = new RoomRepository();
            //3. Actually updating the Room
            roomRepository.UpdateRoom(room);
            //4. Redirect to front page
            return RedirectToAction("Index");
        }

        public ActionResult Show(int id)
        {
            //1: Create a repository
            RoomRepository roomRepository = new RoomRepository();
            //2. Load a single Room
            Room room = roomRepository.LoadRoom(id);
            //3. Translate it to RoomVM
            RoomVM model = new RoomVM();
            model.Id = room.Id;
            model.Name = room.Name;
            model.Description = room.Description;
            model.RoomNumber = room.RoomNumber;
            //4. Send the RoomVM back to the view
            return View(model);
        }

        //POST: Room/Create
        [HttpPost]
        public ActionResult Create(RoomVM model)
        {
            //1. Create a Room object from the RoomVM
            Room room = new Room();
            room.Name = model.Name;
            room.Description = model.Description;
            room.RoomNumber = model.RoomNumber;
            //2. Create a RoomRepository for saving
            RoomRepository roomRepository = new RoomRepository();
            //3. Actually saving the Room
            roomRepository.SaveRoom(room);
            //4. Redirect to front page
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            //1. Create a RoomRepository
            RoomRepository roomRepository = new RoomRepository();
            //2. Delete the Room
            roomRepository.DeleteRoom(id);
            //3. redirect to the index page
            return RedirectToAction("Index");
        }


        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    string theName = collection["Name"];
        //    string theDescription = collection["Description"];
        //    int theRoomNumber = int.Parse(collection["RoomNumber"]); 

        //    //1:Build the Room Object
        //    //2. Save it to the database
        //    //3.Redirect to the Index page
        //    return RedirectToAction("Index");
        //}

    }
}