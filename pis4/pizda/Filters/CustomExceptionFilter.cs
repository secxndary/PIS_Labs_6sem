using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace pizda.Filters
{
    public class CustomExceptionFilterAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            // Handle the exception and set the result to a custom error view
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ContentResult
            {
                Content = "Custom Exception filter works",
                ContentType = "text/plain"
            };

            filterContext.HttpContext.Response.StatusCode = 500;
        }
    }
}