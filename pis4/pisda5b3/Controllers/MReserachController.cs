using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace pisda5b3.Controllers
{
    [Route("it")]
    public class MReserachController : ApiController
    {
        [HttpGet]
        public string m01()
        {
            return $"m01";
        }
    }
}