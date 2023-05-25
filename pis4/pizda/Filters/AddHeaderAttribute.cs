using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pizda.Filters
{
    public class AddHeaderAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Headers.Add("X-MyHeader", "Custom cool header");

            base.OnResultExecuted(filterContext);
        }
    }
}