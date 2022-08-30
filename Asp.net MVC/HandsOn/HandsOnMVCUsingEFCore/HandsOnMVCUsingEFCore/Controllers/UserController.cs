using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingEFCore.Repositories;
using HandsOnMVCUsingEFCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsOnMVCUsingEFCore.Controllers
{
    public class UserController : Controller
    {
        IUserRepository _repository = null;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
        [Route("User/GetUsers")]
        public IActionResult Index()
        {
            List<User> users = _repository.GetUsers();
            return View(users);
        }
        [Route("User/Add")]
        public IActionResult Create()
        {
            ViewBag.Countries = new SelectList(new string[] { "India", "US", "UK", "China" });
            return View();
        }
        [Route("User/Add")]
        [HttpPost]
        public IActionResult Create(User user)
        {
            try
            {
                _repository.Add(user);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View("Error",new ErrorViewModel() {Message=ex.Message,Controller="User",Action="Create" });
            }
           
        }
        [Route("User/Details/{uname}")]
        public IActionResult Details(string uname)
        {
            User user = _repository.GetUser(uname);
            return View(user);
        }
        [Route("User/Edit/{uname}")]
        [HttpGet]
        public IActionResult Edit(string uname)
        {
            User user = _repository.GetUser(uname);
            return View(user);
        }
        [HttpPost]
        [Route("User/Edit/{uname}")]
        public IActionResult Edit(User user)
        {
            _repository.Update(user);

            return RedirectToAction("Index");
        }
        [Route("User/Delete/{uname}")]
        public IActionResult Delete(string uname)
        {
            User user = _repository.GetUser(uname);
            return View(user);
        }
        [HttpPost]
        [Route("User/Delete/{uname}")]
        public IActionResult Delete(User user)
        {
            _repository.Delete(user);

            return RedirectToAction("Index");
        }
    }
}
