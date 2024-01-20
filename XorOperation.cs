using System;

class XorOperation
{
    static void Main()
    {
        int i = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        i = i ^ k;
        k = i ^ k;
        i = i ^ k;

        Console.WriteLine(" " + i + " " + k);
    }
}
