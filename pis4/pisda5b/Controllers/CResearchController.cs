using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pisda5.Controllers
{
    [RoutePrefix("cresearch")]
    public class CResearchController : Controller
    {
        public string C01Get()
        {
            return $"Method: {Request.HttpMethod} \nQueru params: {Request.QueryString} \nURI: {Request.Url} \n Headers: {Request.Headers}";
        }

        public string C01Post()
        {
            string requestBody;
            using (var streamReader = new StreamReader(Request.InputStream))
            {
                requestBody = streamReader.ReadToEnd();
            }
            return $"Method: {Request.HttpMethod} \nQueru params: {Request.QueryString} \nURI: {Request.Url} \n Headers: {Request.Headers} \nBody: {requestBody}";
        }

        public string C02Post()
        {
            string requestBody;
            using (var streamReader = new StreamReader(Request.InputStream))
            {
                requestBody = streamReader.ReadToEnd();
            }
            return $"Status: {Response.StatusCode}\n Headers: {Response.Headers}\n Body: {requestBody}";
        }

        public string C02Get()
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