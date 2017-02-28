using StrengthTrainer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StrengthTrainer.Controllers
{
    public class WorkoutController : Controller
    {
        private StrengthTrainerContext db = new StrengthTrainerContext();

        // GET: workout
        // This will be a single page app experience
        public ActionResult Active()
        {
            // todo - check that is active, if not redirect to workout/start

            return View();
        }

        // GET: workout/start
        public ActionResult Start()
        {
            return View();
        }
        
        // GET: workout/results
        public ActionResult Results()
        {
            var workouts = db.Workouts.ToList();
            return View(workouts);
        }

        [HttpPost]
        public ActionResult StartWorkout()
        {
            // save workout to db

            // redirect to SPA experience
            return RedirectToAction("Active", "Workout");
        }

        [HttpPost]
        public ActionResult FinishWorkout()
        {
            // save enddatetime to workout

            // redirect to SPA experience
            return RedirectToAction("Results", "Workout");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}