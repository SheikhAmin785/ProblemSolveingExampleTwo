using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolveingExampleTwo
{
    class substring
    {
        static void Main()
        {
            string[] arr = new string[100];

            string value = Console.ReadLine();
            for(int i = 0; i < value.Length; i++)
            {
                for(int j = 0; j < value.Length- i; j++)
                {
                    arr[j] = value.Substring(j,i);
                    Console.WriteLine(arr[j]);
                }
            }
           
        }
    }
}
