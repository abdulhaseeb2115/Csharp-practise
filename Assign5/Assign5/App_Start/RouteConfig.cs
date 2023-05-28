using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Assign5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Child", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                        name: "Employee",
                        url: "{controller}/{action}/{id}",
                        defaults: new { controller = "Employee", action = "Index", id = UrlParameter.Optional }
                    );
            





            routes.MapRoute(
                        name: "add",
                        url: "{controller}/{action}/{x}/{y}",
                        defaults: new { controller = "Child", action = "add", x = UrlParameter.Optional, y = UrlParameter.Optional }
                    );



        }
    }
}
