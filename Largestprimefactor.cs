using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolveingExampleTwo
{
    class Largestprimefactor
    { 
        static long LargestPrimeFactor(long n)
        {
            long i = 2;
            while (i * i <= n)
            {
                if (n % i != 0)
                {
                    i++;
                }
                else
                {
                    n /= i;
                }
            }
            return n;
        }

        static void Main()
        {
            long number = 600851475143;
            long result = LargestPrimeFactor(number);

            Console.WriteLine($"The largest prime factor of {number} is: {result}");
        }
    }

}

