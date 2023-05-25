using pizda.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pizda.Controllers
{
    [RoutePrefix("aa")]
    public class AReserachController : Controller
    {
        [CustomActionFilter]
        [HttpGet]
        [Route("aa")]
        public string AA()
        {
            return "{message :'message'}";
        }

        [AddHeader]
        [Route("ar")]
        public string AR()
        {
            return "ar";
        }

        [CustomExceptionFilter]
        [Route("ae")]
        public string AE()
        {
            throw new Exception();
        }
    }
}