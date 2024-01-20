using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolveingExampleTwo
{
    class concat
    {
        static void Main()
        {
            string s1 = "Good";
            string s2 = "morning";
            string s3 = string.Concat(s1, s2);
            Console.WriteLine(s3);
            Console.ReadLine();
        }
        static void main()
        {
            DateTime date = new DateTime(2013, 6, 23);
            string tdate = date.ToString("M");
            Console.WriteLine(" ",date);
            Console.WriteLine(" ",tdate);
        }
    }
}
