using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facade;
using Core;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class TestController : Controller
    {
        public ActionResult GetView()
        {
            var emp = new Employee("Ruben", "Galoyan", 20000);

            var vmEmp = new EmployeeViewModel(emp);
            return View("MyView");
        }
    }
}