using System;
using System.Web;
using System.Web.UI.HtmlControls;

namespace PIS_Lab1
{
    public class IISHandler5 : IHttpHandler
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
            res.AddHeader("Content-Type", "text/html");

            if (req.HttpMethod == "GET")
            {
                res.ContentType = "text/html";
                res.WriteFile("Task4.html");
            }
            else if (req.HttpMethod == "POST")
            {

            }
            else
            {

            }


            //var x = int.Parse(req.Form["x"]);
            //var y = int.Parse(req.Form["y"]);
            //var sum = x + y;
            //res.Write($"<h2>{x} + {y} = {sum}</h2>");
        }

        #endregion
    }
}
