using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task2.Models;
using Task2.ViewModels;

namespace Task2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Traineedetails traineedetails = new Traineedetails()
            {
                TraineeId = 103,
                TraineeName = "Sharon",
                TrainerName = "Kavi",
            };
            Trainerdetails trainerdetails = new Trainerdetails()
            {
                TrainerId = 190,
                TrainerName = "Kavi",
                Subject = "Node.js",
            };
            TrainerTrainee trainertrainee = new TrainerTrainee()
            {
                trainer = trainerdetails,
                trainee = traineedetails
            };
            return View(trainertrainee);
        }
    }
}