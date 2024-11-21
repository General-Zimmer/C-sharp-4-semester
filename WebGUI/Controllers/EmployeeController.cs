using BLL.Employees;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGUI.Controllers
{
    public class EmployeeController : Controller
    {
       
        public ActionResult GetEmployee(int id)
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            return View("Employee", employeeBLL.getEmployee(id));
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                return View("Employee", null);
            }
            EmployeeBLL employeeBLL = new EmployeeBLL();
            employeeBLL.AddEmployee(employee);
            return View("AddConfirmation");
        }
    }
}