using millennium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace millennium.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Person model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Sent", model);
            }

            return View();
        }

        public ActionResult Sent(Person model)
        {
            return View(model);
        }
    }
}