using HandsOnViewModel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnViewModel.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProjectDetails()
        {
            Employee employee = new Employee() { Eid = 1, Ename = "Deepak", Desig = "Programmer" };
            Employee employee1 = new Employee() { Eid = 2, Ename = "Manoj", Desig = "Programmer" };
            List<Employee> employees = new List<Employee>() { employee, employee1 };
            Project project = new Project() { Pid = 1, Pname = "HealthCare", StartDate = DateTime.Now, EndDate = DateTime.Now.AddYears(2) };
            EmployeeProjectViewModel viewModel = new EmployeeProjectViewModel()
            {
                Employees = employees,
                Project = project
            };
            return View(viewModel);
        }
    }
}
