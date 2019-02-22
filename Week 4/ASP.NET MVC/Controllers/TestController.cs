using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello world!";
        }

        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Ruben";
            emp.LastName = "Galoyan";
            emp.Salary = 50000;
            return View("MyView", emp);
        }
    }
}