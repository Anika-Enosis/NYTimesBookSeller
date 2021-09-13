﻿using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AssignmentUpdate
{
    public class APICallBookList 
    {
        string ResponseData;
        public async Task GetResponse(string InputData)
        {
            await Task.Run(() =>
            { 
            string Url = "https://api.nytimes.com/svc/books/v3/lists/" + InputData + "/hardcover-fiction.json?api-key=PoIa9Gvjvni8UxLCVjiXgxgFjOtveAiW";
            WebRequest Request = WebRequest.Create(Url);
            using (WebResponse Response = Request.GetResponse())
            {
                using (StreamReader ResponseReader =
                  new StreamReader(Response.GetResponseStream()))
                {
                    ResponseData = ResponseReader.ReadToEnd();
                    
                }
            }

            });

            var Get_Best_Seller_BookList_Object = new GetBestSellerBookList();
            Get_Best_Seller_BookList_Object.GetRequiredData(ResponseData);
        }

    }
}

