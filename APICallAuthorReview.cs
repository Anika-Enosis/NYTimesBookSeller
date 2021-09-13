using System.IO;
using System.Net;

namespace AssignmentUpdate
{
    internal class APICallAuthorReview : APICall
    {
        string ResponseData;
        public override string GetResponse(string InputData)
        {
            string Url = "https://api.nytimes.com/svc/books/v3/reviews.json?author=" + InputData + "&api-key=PoIa9Gvjvni8UxLCVjiXgxgFjOtveAiW";
            ResponseData = base.GetResponse(Url);
            var GetReview = new GetReviewList();
            GetReview.GetRequiredData(ResponseData);
            return ResponseData;

        }
    }
}