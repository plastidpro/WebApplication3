using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers.Resources
{
    public class ResourcesController : Controller
    {
        // GET: Resources
        public ActionResult Index()
        {
            ViewBag.Lol = "TheLupa";
            return View();
        }
    }
}