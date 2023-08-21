using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task2.Models;

namespace Task2.Controllers
{
    public class TrainerController : Controller
    {
        // GET: Trainer
        public ActionResult Index()
        {
            IList<Trainerdetails> Trainerdetails = new List<Trainerdetails>()
            {
                new Trainerdetails {TrainerId = 101 ,TrainerName = "Harita" ,Subject = "Html,Css"},
                new Trainerdetails {TrainerId = 102 , TrainerName = "Ranita" ,Subject = "Php,Laravel"},
                new Trainerdetails {TrainerId = 103 , TrainerName = "Harishmitha" ,Subject = "Dot.net , Mvc" },
                new Trainerdetails {TrainerId = 104 , TrainerName = "Yamini" , Subject = "React,Angular"}

            };
            return View(Trainerdetails);
        }
        [ChildActionOnly]
        public ActionResult RenderParsialNavbar2()
        {
            return PartialView("ParsialNavbar");
        }
    }
}