using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Test Scenario 1 : Hardcode some value as it is here : Home
            routes.MapRoute(
                name: "Default",
                url: "Home/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                //Mandatory to give a controller name in Default otherwise no controller specified error.
            );

            //Test scenario 3 :( Associated to code of Test Scenario 1)
            //Similar routes but the one that matches first is used. Uncomment and swap with TC 1 to verify results.
            //routes.MapRoute(
            //    name: "Default1",
            //    url: "Home/Index/{id}",
            //    defaults: new { controller = "Home", action = "Print", id = UrlParameter.Optional }
            //    //Mandatory to give a controller name in Default otherwise no controller specified error.
            //);

            

            //Test Scenario 2  : Change order of placeholders in URL.
            //This is similar to the original pattern. The keys action and controller stands for MVC action and controllers.
            routes.MapRoute(
                name: "Default2",
                url: "{action}/{controller}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                //Mandatory to give a controller name in Default otherwise no controller specified error.
            );

        }
    }
}