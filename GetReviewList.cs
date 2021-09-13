namespace AssignmentUpdate
{
    public class GetReviewList : IProcessRequiredData
    {
        public void GetRequiredData(string ResponseData)
        {

            if (ResponseData.Contains("summary"))
            {
                string[] ReviewLines = ResponseData.Split("\"summary\":\"");
                string[] Reviews = new string[ReviewLines.Length];

                for (int i = 1; i < ReviewLines.Length; i++)
                {
                    string[] str = ReviewLines[i].Split("\",");
                    Reviews[i - 1] = str[0];
                }

                var PrintClassObject = new PrintClass();
                PrintClassObject.print(Reviews);
            }
            else
            {
                string[] Reviews = new string[1];
                Reviews[0] = "No review Available";
                var PrintClassObject = new PrintClass();
                PrintClassObject.print(Reviews);

            }

        }
    }
}