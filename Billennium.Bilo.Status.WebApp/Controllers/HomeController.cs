using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Billennium.Bilo.Status.Proxy;

namespace Billenium.Bilo.Status.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var test = new Class1();
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
