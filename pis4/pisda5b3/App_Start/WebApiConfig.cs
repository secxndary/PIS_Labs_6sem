using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace pisda5b3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Конфигурация и службы Web API

            // Маршруты Web API
            config.MapHttpAttributeRoutes();
        }
    }
}
