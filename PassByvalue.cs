using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolveingExampleTwo
{
    class PassByvalue
    {
        static void Cube(int x)
        {
            x = x * x * x;
            Console.WriteLine(x);
        }
        static void Main()
        {
            int x1 = 20;
            Console.WriteLine(x1);
            Cube(x1);
            Console.ReadKey();
        }
    }
}
