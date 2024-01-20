using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolveingExampleTwo
{
    class String
    {
        static void Main()
        {
            string s1 = "Good";
            string s2 = "Morning";
            string s3 = string.Concat(s1, s2);
            Console.WriteLine(s3);
            Console.ReadLine();
        }
        static void Mains()
        {
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            int[] n = new int[x];
            for(int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                n[i] = Int32.Parse(s1);
            }
            Array.Sort(n);
            for(int i = 0; i < x; i++)
            {
                Console.WriteLine(" "+n[i]);
                for(int i = 0; i < x; i++)
                {
                    Console.WriteLine(" "+n[i]);
                }
            }
        }
    }
}
