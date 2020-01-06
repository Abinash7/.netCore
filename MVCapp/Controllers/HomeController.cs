using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCapp.Models;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace MVCapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            String theme = Request.Cookies["theme"];
            if (theme == "dark")
            {
                ViewData["color"] = "white";
                ViewData["bg"] = "grey";
            }
            else if (theme == "light")
            {
                ViewData["color"] = "black";
                ViewData["bg"] = "white";
            }
            else if (theme == "colorful")
            {
                ViewData["color"] = "green";
                ViewData["bg"] = "purple";
            }
            else
            {
                ViewData["color"] = "black";
                ViewData["bg"] = "white";
            }

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            String theme = Request.Cookies["theme"];
            if (theme == "dark")
            {
                ViewData["color"] = "white";
                ViewData["bg"] = "grey";
            }
            else if (theme == "light")
            {
                ViewData["color"] = "black";
                ViewData["bg"] = "white";
            }
            else if (theme == "colorful")
            {
                ViewData["color"] = "green";
                ViewData["bg"] = "purple";
            }
            else
            {
                ViewData["color"] = "black";
                ViewData["bg"] = "white";
            }

            return View();
        }

        public IActionResult Contact()
        {

            String theme = Request.Cookies["theme"];
            if (theme == "dark")
            {
                ViewData["color"] = "white";
                ViewData["bg"] = "grey";
            }
            else if (theme == "light")
            {
                ViewData["color"] = "black";
                ViewData["bg"] = "white";
            }
            else if (theme == "colorful")
            {
                ViewData["color"] = "green";
                ViewData["bg"] = "purple";
            }
            else
            {
                ViewData["color"] = "black";
                ViewData["bg"] = "white";
            }

            return View();
        }

        public IActionResult Option()
        {
            return View();
        }

        public IActionResult UserForm()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DisplayUser(UserInfo user)
        {
            ViewData["name"] = user.FullName;
            ViewData["address"] = user.Address;
            ViewData["phone"] = user.PhoneNumber;
            ViewData["email"] = user.Email;
            return View(user);
        }

        public IActionResult ChangeTheme(String theme)
        {
            CookieOptions cookies = new CookieOptions();
            Response.Cookies.Append("theme", theme);
            return RedirectToAction("index");
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
