using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolveingExampleTwo
{
    class ArrayExample
    {
         static void Print(int m,int n )
        {
           int[,] arr = new int[m,n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
           
        }
        public static void Main()
        {
            ArrayExample obj = new ArrayExample(4, 5);
            obj.print();

        }

        private void print()
        {
            throw new NotImplementedException();
        }
    }
}
