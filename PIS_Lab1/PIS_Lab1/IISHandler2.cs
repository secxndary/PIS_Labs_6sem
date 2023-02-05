using System;
using System.Web;

namespace PIS_Lab1
{
    public class IISHandler2 : IHttpHandler
    {
        #region Члены IHttpHandler

        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;
            var parmA = req.Form["parmA"];
            var parmB = req.Form["parmB"];
            res.AddHeader("Content-Type", "text/plain");
            res.Write($"===== POST =====\nparmA = {parmA}\nparmB = {parmB}");
        }

        #endregion
    }
}
