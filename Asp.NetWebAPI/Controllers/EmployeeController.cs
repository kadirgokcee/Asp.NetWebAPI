using Asp.NetWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Asp.NetWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        private List<Employee> listEmployees = new List<Employee>
        {
            new Employee{ Id = 1,Name="Kadir",LastName="Gökçe"},
            new Employee{ Id = 2,Name="Özgür",LastName="Gökçe"},
            new Employee{ Id = 3,Name="Furkan",LastName="Kızıl"},
            new Employee{ Id = 4,Name="Özcan",LastName="Saçak"},
        };
        public IEnumerable<Employee> GetEmployees()
        {
            return listEmployees;
        }
        public IHttpActionResult GetEmployee(int id)
        {
            var searchEmployee = (from p in listEmployees
                                  where p.Id == id
                                  select p).FirstOrDefault();
            return Ok(searchEmployee);
        }
    }
}
