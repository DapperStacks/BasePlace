using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BasePlace.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your BasePlace for Software Development";
            return View();
        }

        public IActionResult Developer() {
            ViewData["Message"] = "The Developer Portal";
            return View();
        }

        public IActionResult Contracts() {
            ViewData["Message"] = "Our Contracts";
            return View();
        }

        public IActionResult Videos() {
            ViewData["Message"] = "Our Video Tutorials";
            return View();
        }

        public IActionResult Network() {
            ViewData["Message"] = "Employee Database";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
