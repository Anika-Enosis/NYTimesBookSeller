namespace AssignmentUpdate
{
    public class GetBestSellerAuthorlist : IProcessRequiredData
    {
        public void GetRequiredData(string ResponseData)
        {
            string[] AutherName = ResponseData.Split("\"author\":\"");
            string[] BookAuthors = new string[AutherName.Length];

            for (int i = 1; i < AutherName.Length; i++)
            {
                string[] AuthorNames = AutherName[i].Split("\"");
                BookAuthors[i - 1] = AuthorNames[0];
            }

            
        }
    }
}

