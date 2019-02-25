using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_MVC.Filters;
using Facade;
using Infra;
using Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly SalesDbContext db;

        public EmployeeController(SalesDbContext db) {this.db = db;}

        [Authorize]
        public ActionResult Index()
        {
            var model = new EmployeeListViewModel();
            model.UserName = User.Identity.Name;
            var employees = Employees.Get(db);
            var list = new List<EmployeeViewModel>();
            foreach (var e in employees)
            {
                var employee = new EmployeeViewModel(e);
                list.Add(employee);
            }

            model.Employees = list;
            model.FooterData = new FooterViewModel();
            model.FooterData.CompanyName = "TalTech";
            model.FooterData.Year = DateTime.Now.Year.ToString();
            return View("Index", model);
        }

        [Authorize]
        [AdminFilter]
        public ActionResult AddNew()
        {
            return View("CreateEmployee",new CreateEmployeeViewModel());
        }

        [AdminFilter]
        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            if (BtnSubmit != "Save Employee") return RedirectToAction("Index");
            if (!ModelState.IsValid) return View("CreateEmployee");
            return save(e);
        }

        private ActionResult save(Employee e)
        {
            Employees emp = new Employees();
            emp.Save(e, db);
            return RedirectToAction("Index");
        }
    }
}