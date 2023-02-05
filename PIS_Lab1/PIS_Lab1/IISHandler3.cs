using System;
using System.Web;

namespace PIS_Lab1
{
    public class IISHandler3 : IHttpHandler
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
            var parmA = req["parmA"];
            var parmB = req["parmB"];
            res.AddHeader("Content-Type", "text/plain");
            res.Write($"===== PUT =====\nparmA = {parmA}\nparmB = {parmB}");
        }

        #endregion
    }
}
