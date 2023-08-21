using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task2.Models;
namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IList<Companydetails> Companydetails = new List<Companydetails>();
            {
                Companydetails.Add(new Companydetails() { Id = 1, Name = "Cgvak", Description = "Good"});           
                Companydetails.Add(new Companydetails() { Id = 2, Name = "G2Tech", Description = "Ok"});
            };
            ViewData["Companydetails"] = Companydetails;

            ViewBag.Skillsets = new List<string>{
            "Time Management",
            "Creativity",
            "Leadership",
            "Team Work",
            "Problem Solving",
            "Desicion Making"
         }; return View(Companydetails);
        }

    }
}