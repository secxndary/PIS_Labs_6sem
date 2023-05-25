using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace pizda.Controllers
{
    [RoutePrefix("ch")]
    public class CHResearchController : Controller
    {
        [OutputCache(Duration = 5, Location = OutputCacheLocation.Server)]
        [HttpGet]
        [Route("ad")]
        public string AD()
        {
            return $"ad: {DateTime.Now}";
        }

        [HttpPost]
        [OutputCache(Duration = 7, VaryByParam = "y", Location = OutputCacheLocation.Server)]
        [Route("ap")]
        public int AP(int x, int y)
        {
            return x + y;
        }

    }
}