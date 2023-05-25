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
            routes.IgnoreRoute("v2/mresearch/m03");

            //routes.MapMvcAttributeRoutes();
            /*
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
            */


            routes.MapRoute(
                "mxx",
                "mxx",
                new { controller = "MResearch", action = "MXX" }
            );

            routes.MapRoute(
                "v3/controller/x/action", 
                "v3/{controller}/{x}/{action}", 
                new { controller = "MResearch", action = "M03", x = UrlParameter.Optional}
            );

            routes.MapRoute(
                "v2/controller/action", 
                "v2/{controller}/{action}", 
                new { controller = "MResearch", action = "M02" }
            );

            routes.MapRoute("c/action/id", "cresearch/{action}/{id}", new
            {
                controller = "CResearch",
                action = "C01",
                id = UrlParameter.Optional
            });


            routes.MapRoute("controller/action/id", "{controller}/{action}/{id}", new
            {
                controller = "MResearch",
                action = "M01",
                id = UrlParameter.Optional
            });

            /*
            var m01 = new List<string>() 
            {
                "mresearch/m01/1",
                "mresearch/m01",
                "mresearch",
                "",
                "v2/mresearch/m01",
                "v3/mresearch/{x}/m01",
            };

            var m02 = new List<string>()
            {
                "v2",
                "v2/mresearch",
                "v2/mresearch/m02",
                "mresearch/m02",
                "v3/mresearch/{x}/m02",
            };

            var m03 = new List<string>()
            {
                "v3",
                "v3/mresearch/{x}",
                "v3/mresearch/{x}/m03",
            };

            foreach (var item in m01) 
            {
                routes.MapRoute(
                name: item,
                url: item,
                defaults: new { controller = "MResearch", action = "M01" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );
            }

            foreach (var item in m02)
            {
                routes.MapRoute(
                name: item,
                url: item,
                defaults: new { controller = "MResearch", action = "M02" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );
            }

            foreach (var item in m03)
            {
                routes.MapRoute(
                name: item,
                url: item,
                defaults: new { controller = "MResearch", action = "M03" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );
            }

            var c01 = new List<string>()
            {
                "cresearch",
                "cresearch/c01",
            };

            foreach (var item in c01)
            {
                routes.MapRoute(
                name: item+"get",
                url: item,
                defaults: new { controller = "CResearch", action = "C01Get" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

                routes.MapRoute(
                    name: item + "post",
                    url: item,
                    defaults: new { controller = "CResearch", action = "C01Post", method = "POST" },
                    constraints: new { httpMethod = new HttpMethodConstraint("POST") }
                );
            }

            routes.MapRoute(
                name: "c02get",
                url: "cresearch/c02",
                defaults: new { controller = "CResearch", action = "C02Get" }
                );

            routes.MapRoute(
                name: "c02post",
                url: "cresearch/c02",
                defaults: new { controller = "CResearch", action = "C02Post" },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") }
            );

            routes.MapRoute(
                name: "404",
                url: "mxx",
                defaults: new { controller = "MReserach", action = "MXX" }
            );

            */

        }
    }
}
