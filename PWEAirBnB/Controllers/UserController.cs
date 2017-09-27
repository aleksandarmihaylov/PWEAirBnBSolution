using PWEAirBnB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PWEAirBnB.Controllers
{
    // This is going to be my user controller
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Show()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Create(UserVM model)
        {
            return RedirectToAction("Index");
        }
    }
}