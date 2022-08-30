using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult Greet()
        {
            return View();
        }
    }
}
