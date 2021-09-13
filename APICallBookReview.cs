using System.IO;
using System.Net;

namespace AssignmentUpdate
{
    public class APICallBookReview : APICall
    {
        string ResponseData;
        public override string GetResponse(string InputData)
        {
            string Url = "https://api.nytimes.com/svc/books/v3/reviews.json?title=" + InputData + "&api-key=PoIa9Gvjvni8UxLCVjiXgxgFjOtveAiW";
            ResponseData = base.GetResponse(Url);
            var GetReviewListObject= new GetReviewList();
            GetReviewListObject.GetRequiredData(ResponseData);
            return ResponseData;
        }
    }
}
