using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnModels.Models;
using HandsOnModels.Models.Repositories;
namespace HandsOnModels.Controllers
{
    public class StudentController : Controller
    {
        private StudentRepository repository = null;
        public StudentController()
        {
            repository = new StudentRepository();
        }
        public IActionResult Index()
        {
            List<Student> students=repository.GetStudents();
            return View(students); //pasing list of students ot view page.
        }
        public IActionResult Details(int sid)
        {
            Student student=repository.GetStudent(sid);
            if (student != null)
            {
                return View(student);
            }
            else
            {
                string errMsg = "Invalid ID";
                //ViewData is an object use to passing data from action method to view page.
                ViewData["err"] = errMsg;
                return View();
            }
        }
        [HttpGet]
        public IActionResult Create() //action use to get student detials from the user
        {
            return View();
        }
        //public IActionResult AddStudent(Student student)
        //{
        //    repository.Add(student);
        //    return RedirectToAction("Index"); //Redirect to Index Action method
        //}
        [HttpPost]
        public IActionResult Create(Student student) //add student details to list/table
        {
            repository.Add(student);
            return RedirectToAction("Index"); //Redirect to Index Action method
        }
    }
}
