using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace pizda.Controllers
{
    [RoutePrefix("it")]
    public class MReserachController : Controller
    {
        [HttpGet]
        [Route("{b:int}/{str}")]
        public string M01(int b, string str)
        {
            return $"M01:{Request.HttpMethod}:{b}/{str}";
        }

        [HttpGet]
        [Route("{b:bool}/{str:regex(^[a-zA-Z]+$)}")]
        public string M02(bool b, string str)
        {
            return $"M02:{Request.HttpMethod}:{b}/{str}";
        }

        [Route("{b:bool}/{str:regex(^[a-zA-Z]+$)}")]
        [HttpPost]
        public string M02Post(bool b, string str)
        {
            return $"M02:{Request.HttpMethod}:{b}/{str}";
        }

        [HttpGet]
        [Route("{b:float}/{str:length(1,5)}")]
        public string M03(float b, string str)
        {
            return $"M03:{Request.HttpMethod}:{b}/{str}";
        }

        [HttpDelete]
        [Route("{b:float}/{str:length(1,5)}")]
        public string M03Delete(float b, string str)
        {
            return $"M03:{Request.HttpMethod}:{b}/{str}";
        }

        [HttpPut]
        [Route("{str:regex(^[a-zA-Z]+$):length(3,4)}/{n:range(100,200)}")]
        public string M04(string str, int n)
        {
            return $"M04:{Request.HttpMethod}:{str}/{n}";
        }

        [HttpPost]
        [Route(@"{str:regex(^[a-zA-Z]+@[a-zA-Z]+\.[a-zA-Z]+$)}")]
        public string M05(string str)
        {
            return $"M05:{Request.HttpMethod}:{str}";
        }
    }
}