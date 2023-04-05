using System.Web.Mvc;
using System.Web.Routing;

namespace PIS_Lab5b
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute("AReserach_Action", "AA", new { controller = "AResearch", action = "AA" });
            routes.MapRoute("AReserach_Result", "AR", new { controller = "AResearch", action = "AR" });
            routes.MapRoute("AReserach_Exception", "AE", new { controller = "AResearch", action = "AE" });

            routes.MapRoute("MXX", "MResearch/MXX", new { controller = "MResearch", action = "MXX" });
        }
    }
}
