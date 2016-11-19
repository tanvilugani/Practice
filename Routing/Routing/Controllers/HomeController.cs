using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return Content("Home Controller Index Get Method");
        }

        public ActionResult Print()
        {
            return Content("Home Controller Print Get Method");
        }

    }
}
