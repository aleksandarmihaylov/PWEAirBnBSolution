using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PWEAirBnB.Controllers
{
    //This is going to be my host controller
    public class HostController : Controller
    {
        // GET: Host
        public ActionResult Index()
        {
            return View();
        }
    }
}