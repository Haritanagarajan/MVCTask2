using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task2.Models;
using static System.Collections.Specialized.BitVector32;

namespace Task2.Controllers
{
    public class TraineeController : Controller
    {
        // GET: Trainee
        public ActionResult Index()
        {
            IList<Traineedetails> Traineedetails = new List<Traineedetails>()
            {
              new Traineedetails {TraineeId = 1,TrainerName = "Harita" ,TraineeName = "Pallavi"},
              new Traineedetails {TraineeId = 2,TrainerName = "Ranita" ,TraineeName = "Thangam"},
              new Traineedetails {TraineeId = 3,TrainerName = "Harishmitha" ,TraineeName = "Arun"},
              new Traineedetails {TraineeId = 4,TrainerName = "Yamini" ,TraineeName = "Dharshan"}

            };
            return View(Traineedetails);
        }
        [ChildActionOnly]
        public ActionResult RenderParsialNavbar1()
        {
            return PartialView("ParsialNavbar");
        }
       
    }
}