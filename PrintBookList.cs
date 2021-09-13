using System;
using System.IO;
using System.Threading.Tasks;
using AssignmentUpdate;

namespace AssignmentUpdate
{
    public class PrintBookList 
    {

        public void print(string[] Books, string[] Authors)
        {
            int k = 0;
            // Console.WriteLine("\n\n\nBest Seller book of date " + date);
            //Task t = new Task(() =>
            //{
            lock ("output1.txt")
            {
                foreach (string Book in Books)
                {
                    using (StreamWriter StreamWriterObject = File.AppendText("output1.txt"))
                    {
                        if (Book != null)
                        {
                            Console.WriteLine("Title : " + Book + " Author : " + Authors[k]);
                            StreamWriterObject.WriteLine("Title : " + Book + " Author : " + Authors[k]);
                            k += 1;

                        }
                        else
                        {
                            Console.WriteLine("Time after showing booklist  " + " is " + DateTime.Now.ToString("HH:mm:ss"));
                            var VariableObject= new Variables();
                            var FromTime = VariableObject.FromTime;
                            DateTime ToTime = DateTime.Now;
                            TimeSpan ResultTime = ToTime - FromTime;
                            VariableObject.TimeInMiliSecond += ResultTime.Milliseconds + ResultTime.Seconds * 1000;
                            Console.WriteLine("Time needed " + VariableObject.TimeInMiliSecond);
                            int Time_MiliSecond = VariableObject.TimeInMiliSecond;
                            StreamWriterObject.WriteLine("Time needed " + VariableObject.TimeInMiliSecond);
                            VariableObject.FromTime = ToTime;
                            Console.WriteLine("\n\n");
                        }
                        StreamWriterObject.Close();
                    }
                }
            }
        //});
        //t.RunSynchronously(); 
        }
    }
}