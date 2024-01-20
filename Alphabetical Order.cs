using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolveingExampleTwo
{
    class Alphabetical_Order
    {
        static void Main()
        {
            List<string> names = new List<string>();
            names.Add("alamin");
            names.Add("jamal");
            names.Add("kamal");
            names.Add("abdul");
            names.Sort();
            foreach(string s in names)
            {
                Console.WriteLine(s);
                Console.ReadLine();
            }
        }
    }
}
