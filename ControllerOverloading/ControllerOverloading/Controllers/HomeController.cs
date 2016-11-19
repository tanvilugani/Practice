using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerOverloading.Controllers
{
    public class HomeController : Controller
    {
        //Method 1 for Controller Overloading - using HTTP verbs.
        [HttpGet]
        public ActionResult Index()
        {

            return Content("Index Get Method");
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            return Content("Index Post Method");
        }

        //Method 2 for Controller Overloading - using Non Action attribute.
        [HttpGet]
        public ActionResult Home()
        {
            Home(1);
            return Content("Home Get Method");
        }

        [NonAction]
        public ActionResult Home(int id)
        {
            return Content("Home Non Action");
        }

        //Method 3 for Controller Overloading - Use Action Name attribute.
        [ActionName("FirstActionName")]
        public ActionResult ActionName()
        {
            return Content("First Action Name");
        }

        [ActionName("SecondActionName")]
        public ActionResult ActionName(int id)
        {
            return Content("Second Action Name");
        }

        //Method 4 for Controller Overloading : Using routes - Not sure why this ain't working.
        
        //[Route("Home/DoWork/{id:int}")]
        //public ActionResult RoutingMethod(int id)
        //{
        //    return Content("Routing method int");
        //}

        //[Route("Home/DoWork/{value:bool}")]
        //public ActionResult RoutingMethod(bool value)
        //{
        //    return Content("Routing method bool");
        //}
    }
}
