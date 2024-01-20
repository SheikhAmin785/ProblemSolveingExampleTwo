using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolveingExampleTwo
{
    class EvenFibonaccinumber
    {
        static void Evenfibo()
        {
            int limit = 4000000;
            int sum = 0;
            int first = 1;
            int second = 2;
            while (second <= limit)
            {
                if (second % 2 == 0)
                {
                    sum = sum + second;
                }
                int next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine("the sum of even value term"+sum);


        }
    }
}
