using System;

namespace AssignmentUpdate
{
    public class PrintClass
    {
        public void print(string[] Reviews)
        {
            foreach (string Review in Reviews)
            {
                Console.WriteLine(Review);
            }
        }
    }
}