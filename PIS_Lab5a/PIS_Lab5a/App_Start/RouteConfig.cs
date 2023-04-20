using System.Web.Mvc;
using System.Web.Routing;

namespace PIS_Lab5a
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();


            routes.MapRoute("V3",                       "V3",                           new { controller = "MResearch", action = "M03" });
            routes.MapRoute("V3/Controller/X/Action",   "V3/{controller}/X/{action}",   new { controller = "MResearch", action = "M03" });
            routes.MapRoute("V2/Controller/Action",     "V2/{controller}/{action}",     new { controller = "MResearch", action = "M02" });
            routes.MapRoute("Controller/Action/Id",     "{controller}/{action}/{id}",   new { controller = "MResearch", action = "M01", 
                                                                                                            id = UrlParameter.Optional });

            routes.MapRoute("MXX",                      "MResearch/MXX",                new { controller = "MResearch", action = "MXX" });
        }
    }
}
