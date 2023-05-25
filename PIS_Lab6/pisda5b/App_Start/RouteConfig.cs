using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace pisda5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            
            var res = "";

            foreach (var route in RouteTable.Routes)
            {
                try
                {
                    if (route == null || ((Route)route)?.Url == null || ((Route)route)?.Defaults == null)
                        continue;
                }
                catch { continue; }

                res += ("URL: ", ((Route)route).Url);
                res += ("Defaults: ", string.Join(",", ((Route)route).Defaults.Select(x => x.Key + "=" + x.Value)));
                res += ("Constraints: ", string.Join(",", ((Route)route).Constraints.Select(x => x.Key + "=" + x.Value)));
                res += "\n";
            }

            Console.WriteLine(res);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
