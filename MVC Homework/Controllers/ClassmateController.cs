using System.Collections.Generic;
using System.Web.Mvc;
using MVC_Homework.Models;

namespace MVC_Homework.Controllers
{
    public class ClassmateController : Controller
    {
        // GET: Classmate
        public ActionResult Index()
        {
            var classmates = new List<ClassMate>
            {
                new ClassMate(1, "Seth", "Black", 5.0),
                new ClassMate(2, "Brain", "Black", 5.0),
                new ClassMate(2, "Zach", "Brown", 5.0),
                new ClassMate(2, "Trey", "Stoner", 5.0),
                new ClassMate(2, "Kate", "Brown", 5.0),
                new ClassMate(2, "Tee", "Brown", 5.0),
                new ClassMate(2, "Kevin", "Brown", 5.0)
            };
            return View(classmates);
        }
    }
}