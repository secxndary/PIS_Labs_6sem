using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pisda5.Controllers
{
    public class CResearchController : Controller
    {
        public string C01()
        {
            string requestBody;
            using (var streamReader = new StreamReader(Request.InputStream))
            {
                requestBody = streamReader.ReadToEnd();
            }
            return $"Method: {Request.HttpMethod} \nQueru params: {Request.QueryString} \nURI: {Request.Url} \n Headers: {Request.Headers}\n Body: {requestBody}";
        }


        public string C02()
        {
            string requestBody;
            using (var streamReader = new StreamReader(Request.InputStream))
            {
                requestBody = streamReader.ReadToEnd();
            }
            return $"Status: {Response.StatusCode}\n Headers: {Response.Headers}\n Body: {requestBody}";
        }

    }
}