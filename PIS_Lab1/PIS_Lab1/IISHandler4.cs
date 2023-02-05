using System;
using System.Web;

namespace PIS_Lab1
{
    public class IISHandler4 : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;
            var x = int.Parse(req.Form["x"]);
            var y = int.Parse(req.Form["y"]);
            var sum = x + y;
            res.AddHeader("Content-Type", "text/html");
            res.Write($"<h2>{x} + {y} = {sum}</h2>");
        }
    }
}
