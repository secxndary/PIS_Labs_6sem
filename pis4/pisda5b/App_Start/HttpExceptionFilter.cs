using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace pisda5.App_Start
{
    public class HttpExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is HttpException httpException)
            {
                if (httpException.GetHttpCode() == 404)
                {
                    //context.Result = new RedirectResult("mxx");
                }
            }
        }
    }
}