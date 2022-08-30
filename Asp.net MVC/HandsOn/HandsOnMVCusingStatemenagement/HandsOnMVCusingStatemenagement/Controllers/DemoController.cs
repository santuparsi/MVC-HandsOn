using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCusingStatemenagement.Models;
namespace HandsOnMVCusingStatemenagement.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult View1()
        {
            // return RedirectToAction("View2",new {name="Rohan" });
            return RedirectToAction("Details", new User() { });
        }
        public IActionResult View2(string name)
        {
            ViewData["un"] = name;
            return View();
        }
        public IActionResult Details(User user)
        {
            return View(user);
        }
    }
}
