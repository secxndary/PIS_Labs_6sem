using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pisda5.Controllers
{
    [RoutePrefix("it")]
    public class MResearchController : Controller
    {

        [HttpGet]
        [HttpPost]
        [Route("{b:bool}/str:regex(^[a-zA-Z]+$)")]
        public string M02(bool b, string str)
        {
            return $"GET/{Request.HttpMethod}:M02:{b}/{str}";
        }

        [HttpGet]
        [Route("{f:float}/str:length(2,5)")]
        public string M03( float f, string str)
        {
            return $"GET/{Request.HttpMethod}:M03:{f}/{str}";
        }
    }
}