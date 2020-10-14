using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace InTheBag.Controllers
{
    public class AllAboutResultsController : Controller
    {
        public IActionResult Index()
        {
            var weekday = DateTime.Now.Day;
            var day = weekday.ToString();
            var time = DateTime.Now.Hour;

            if (time <= 6)
            {
                ViewBag.Greeting = "Good morning";
            }
            else if (time <= 12)
            {
                ViewBag.Greeting = "Good afternoon";
            }
            else if (time <= 18)
            {
                ViewBag.Greeting = "Good evening";
            }
            int route = 0;

            day = "Monday";

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                    ViewData["dayMessage"] = "The work week just started! Stay focused, you have a lot to do this week!";
                    route = 1;
                    break;
                case "Wednesday":
                    ViewData["dayMessage"] = "Halfway to th weekend!";
                    route = 2;
                    break;
                case "Thursday":
                    ViewData["dayMessage"] = "Isn't Friday somewhere?";
                    route = 3;
                    break;
                case "Friday":
                    ViewData["dayMessage"] = "Woo hoo TGIF";
                    route = 4;
                    break;
                default:
                    ViewData["dayMessage"] = "Ahhhhh  the weekend!";
                    route = 5;
                    break;
            }

            if (route==1)
            {
                return RedirectToAction("Weekday", "AllAboutResults");
            }
            else if (route==2 || route==3)
            {
                return Redirect("https://lisabalbach.com/CIT218/Chapter8/HappyWednesday.html");
            }
            else
            {
                return View();
            }

            
        }

        public IActionResult Weekday()
        {
            ViewBag.Greeting = "Congratulations, the work week just started and you have been rerouted!";
            return View();
        }
    }
}