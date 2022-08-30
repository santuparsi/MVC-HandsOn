using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCPassingDatabetweenActionMethodtoView.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show()
        {
            string Uname = "David";
            //set value
            ViewData["un"] = Uname;
            ViewBag.Uname = Uname;
            return View();
        }
    }
}
