using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolveingExampleTwo
{
    class GreatestCommonDivisor

    {
        static int Gcd(int n1, int n2)
        {
            int Remainder;
            while (n2 != 0)
            {
                Remainder = n1 % n2;
                n1 = n2;
                n2 = Remainder;

                return n1;
            }
            static void Main()
            {
                int x, y;
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                Gcd(x, y);
                Console.WriteLine($"{Gcd(x, y)}");
                Console.ReadLine();

            }
        }
    }
}
