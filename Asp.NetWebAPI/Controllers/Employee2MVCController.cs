using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.NetWebAPI.Controllers
{
    public class Employee2MVCController : Controller
    {
        // GET: Employee2MVC
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmployeeDetails()
        {
            return View();
        }
        public ActionResult GetEmployee()
        {
            return View();
        }
        public ActionResult NewEmployee()
        {
            return View();
        }
    }
}