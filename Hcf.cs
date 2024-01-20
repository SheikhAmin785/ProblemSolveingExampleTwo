using System;

namespace ProblemSolvingExampleTwo
{
    class Hcf
    {
        static void Main()
        {
            int hcf = 0;
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n1 && i <= n2; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    hcf = i;
                }
            }

            Console.WriteLine(hcf);
            Console.ReadLine();
        }
    }
}
