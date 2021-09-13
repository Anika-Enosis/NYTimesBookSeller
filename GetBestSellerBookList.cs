namespace AssignmentUpdate
{
    public class GetBestSellerBookList : IProcessRequiredData
    {
        public void GetRequiredData(string ResponseData)
        {
            string[] Titles = ResponseData.Split("\"title\":\"");
            string[] Books = new string[Titles.Length];
            string[] AuthorNames = ResponseData.Split("\"author\":\"");
            string[] Authors = new string[AuthorNames.Length];

            for (int i = 1; i < Titles.Length; i++)
            {
                string[] ResultBooks = Titles[i].Split("\"");
                Books[i - 1] = ResultBooks[0];
                string[] AuthorSplitResult = AuthorNames[i].Split("\"");
                Authors[i - 1] = AuthorSplitResult[0];
            }

            var PrintBookListObject = new PrintBookList();
            PrintBookListObject.print(Books,Authors);
        }
    }
}