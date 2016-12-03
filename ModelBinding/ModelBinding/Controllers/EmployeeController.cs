using ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBinding.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeHandler _employeeHandler;

        //Controller will work only if it has a parameterless constructor. Same for model.
        public EmployeeController()
        {
            _employeeHandler = new EmployeeHandler();
        }

        public ActionResult Index()
        {
            var employees = _employeeHandler.GetEmployees();
            //var employeeHandler = new EmployeeHandler();
            //var employees = employeeHandler.GetEmployees();

            return View(employees);
        }

        public ActionResult AddUpdate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUpdate(Employee employee)
        {
            _employeeHandler.AddEmployee(employee);

            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public ActionResult Delete(List<Employee> employees)
        //{
        //    var existingEmployeees = _employeeHandler.DeleteEmployee(employees);
        //    return View("Index", existingEmployeees); 
        //}

        [HttpPost]
        public ActionResult Delete()
        {
            var employees = new List<Employee>();

            var isModelUpdated = TryUpdateModel(employees);


            if (ModelState.IsValid)
            {
                var existingEmployeees = _employeeHandler.DeleteEmployee(employees);
                return View("Index", existingEmployeees);

            }

            return View("Index", employees);
            
        }
    }
}
