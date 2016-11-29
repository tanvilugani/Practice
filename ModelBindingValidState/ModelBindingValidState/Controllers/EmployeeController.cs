using ModelBindingValidState.Models;
using System.Web.Mvc;

namespace ModelBindingValidState.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            var employee = new Employee();

            employee = employee.GetEmployee();

            return View(employee);
        }

        /// <summary>
        /// Inspect ModelState in Debug->Windows->Local Window when in debug mode to see different properties it holds.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            var modelState = ModelState;

            return View();
        }

    }
}
