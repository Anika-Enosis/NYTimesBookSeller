using System;
using System.IO;
using System.Threading.Tasks;

namespace AssignmentUpdate
{
    class Program
    {
        
        static async Task Main(string[] args)
        {
            var VariablesObject = new Variables();
            VariablesObject.TimeInMiliSecond = 0;
            Task Task1 = null;
            Console.WriteLine("Enter date in format(\"YYYY-MM-DD\") seperating by \",\"");
            string Dates = Console.ReadLine();
            string[] DateArray = Dates.Split(",");
            VariablesObject.FromTime = DateTime.Now;
            Console.WriteLine("Time of calling BookList " + " is " + DateTime.Now.ToString("HH:mm:ss"));
            VariablesObject.StreamWriterObject = new StreamWriter("output1.txt");
            VariablesObject.StreamWriterObject.WriteLine("Time of calling BookList " + " is " + DateTime.Now.ToString("HH:mm:ss"));
            VariablesObject.StreamWriterObject.Close();
            var APICallBookListObject = new APICallBookList();

            foreach (string EachEate in DateArray)
            {
                Task1 = APICallBookListObject.GetResponse(EachEate);
               
            }
            await Task.WhenAll(Task1);

            Console.WriteLine("Need More results?press \"2\" for \"Book Review\" \n press \"3\" for \"Author Review\"");
            string Pressed = Console.ReadLine();

            if (Pressed == (2.ToString()))
            {
                Console.WriteLine("Enter book title: ");
                string BookTitle = Console.ReadLine();
                string Title = BookTitle.ToUpper();
                Title = Title.Replace(" ", "%20");
                var APICallBookReviewObject = new APICallBookReview();
                APICallBookReviewObject.GetResponse(Title);
            }
            else if (Pressed == (3.ToString()))
            {
                Console.WriteLine("Enter Author Name: ");
                string AuthorName = Console.ReadLine();
                string author = AuthorName.Replace(" ", "%20");
                var APICallAuthorReviewObject = new APICallAuthorReview();
                APICallAuthorReviewObject.GetResponse(author);
            }

            
        }

    }
}
