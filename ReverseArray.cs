using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolveingExampleTwo
{
    class ReverseArray
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach(int array in arr)
            {
                Console.WriteLine(array);
            }
            Array.Reverse(arr);
            foreach(int value in arr)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
