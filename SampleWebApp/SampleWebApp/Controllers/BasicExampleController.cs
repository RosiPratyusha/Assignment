using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{
    public class BasicExampleController : Controller
    {
        // GET: BasicExample
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string Greeting()
        {
            return "Welcome to ASP.NET MVC Application";
        }
        public Employee Display()
        {
            var employee = new Employee { EmpId = 123, EmpName = "rosi", EmpSalary = 300000.00 , EmpAddress = "Bangalore" };
            return employee;
        }
        public ViewResult EmpDetails()
        {
            var employee = new Employee { EmpId = 123, EmpName = "rosi", EmpSalary = 300000.00, EmpAddress = "Bangalore" };
            return View(employee);
        }
    }
}