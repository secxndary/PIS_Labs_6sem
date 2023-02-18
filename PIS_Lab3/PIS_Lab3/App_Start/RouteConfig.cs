﻿using System.Web.Mvc;
using System.Web.Routing;

namespace PIS_Lab3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "2-parameters Route",
                url: "Dict/{action}",
                defaults: new { controller = "Dict", action = "Index" }
            );

            routes.MapRoute(    
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Dict", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}