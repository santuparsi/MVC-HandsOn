using HandsOnMVCusingHelpersandModelValidation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCusingHelpersandModelValidation.Context;
namespace HandsOnMVCusingHelpersandModelValidation.Controllers
{
    public class EmployeeController : Controller
    {
        EMSContext db = null;
        //public EmployeeController()
        //{
        //    db = new EMSContext();
        //}

        public EmployeeController(EMSContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            List<Employee> employees = db.Employees.ToList();
            return View(employees);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                //write code to add Employee details to table
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Create1() //design the template using stronly typed helpers
        {
            return View();
        }
        public IActionResult Create2() //design the template using tag helpers
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create2(Employee employee)
        {
            if (ModelState.IsValid)
            {
                //write code to add Employee details to table
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
