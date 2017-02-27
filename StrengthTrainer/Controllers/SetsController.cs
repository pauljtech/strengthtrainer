using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StrengthTrainer.Controllers
{
    public class SetsController : Controller
    {
        // GET: Sets
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSet()
        {
            return new RedirectResult("~/Sets");
        }

        public ActionResult EndWorkout()
        {
            return new RedirectResult("~/");
        }
    }
}