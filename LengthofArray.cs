using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolveingExampleTwo
{
    class LengthofArray
    {
        static void Main()
        {
            int[] arr = new int[5];
            int length = arr.Length;
            Console.WriteLine("array length"+length);
            long longlength = arr.LongLength;
            Console.WriteLine("length of the long length array {0}",longlength);
            int[,] two = new int[5, 10];
            Console.WriteLine("this size of 2d array of"+two.Length);
            Console.ReadLine();
        }
    }
}
