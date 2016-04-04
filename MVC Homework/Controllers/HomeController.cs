using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Homework.Models;

namespace MVC_Homework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ClassMate> ClassMates = new List<ClassMate>()
            {
                new ClassMate(1, "Seth", "Black", 5.0),
                new ClassMate(2, "Brain", "Black", 5.0),
                new ClassMate(2, "Zach", "Brown", 5.0),
                new ClassMate(2, "Trey", "Stoner", 5.0),
                new ClassMate(2, "Kate", "Brown", 5.0),
                new ClassMate(2, "Tee", "Brown", 5.0),
                new ClassMate(2, "Kevin", "Brown", 5.0),
            };
            return View(ClassMates);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}