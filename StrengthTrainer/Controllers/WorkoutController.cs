using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StrengthTrainer.Controllers
{
    public class WorkoutController : Controller
    {
        // GET: Workout
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Start()
        {
            return new RedirectResult("~/Sets");
        }
    }
}