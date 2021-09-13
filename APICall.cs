using System;
using System.IO;
using System.Net;

namespace AssignmentUpdate
{
    public class APICall
    {
        public string ResponseData;
        public virtual string GetResponse(string Url)
        {
            WebRequest Request = WebRequest.Create(Url);
            using (WebResponse Response = Request.GetResponse())
            {
                using (StreamReader ResponseReader =
                  new StreamReader(Response.GetResponseStream()))
                {
                    ResponseData = ResponseReader.ReadToEnd();
                }
            }
           
            return ResponseData;
        }
    }
}