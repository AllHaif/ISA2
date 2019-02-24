using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facade;
using Infra;
using Core;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly SalesDbContext db;

        public EmployeeController(SalesDbContext db) {this.db = db;}
        public ActionResult Index()
        {
            var model = new EmployeeListViewModel();
            var employees = Employees.Get(db);
            var list = new List<EmployeeViewModel>();
            foreach (var e in employees)
            {
                var employee = new EmployeeViewModel(e);
                list.Add(employee);
            }

            model.Employees = list;
            return View("Index", model);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    return Content(e.FirstName + "|" + e.LastName + "|" + e.Salary);
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }
    }
}