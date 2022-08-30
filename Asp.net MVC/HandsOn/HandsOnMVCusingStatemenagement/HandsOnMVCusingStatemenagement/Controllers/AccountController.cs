using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCusingStatemenagement.Models;
using Microsoft.AspNetCore.Http;

namespace HandsOnMVCusingStatemenagement.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            if(user.Uname=="Rohan" && user.Password=="12345")
            {
                //set string value in session
                HttpContext.Session.SetString("un",user.Uname);
                HttpContext.Session.SetInt32("flag", 12);
                return RedirectToAction("Details");
            }
            else
            {
                ViewBag.ErrMsg = "Invalid Credentials";
                return View();
            }
        }
        public IActionResult Details()
        {
            ViewBag.Uname = HttpContext.Session.GetString("un"); //read session
            return View();
        }
        public IActionResult View1()
        {
            ViewBag.Uname = HttpContext.Session.GetString("un"); //read session
            ViewBag.Flag = HttpContext.Session.GetInt32("flag");
            return View();
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear(); //clears all the session data.
            return RedirectToAction("Login");
        }
    }
}
