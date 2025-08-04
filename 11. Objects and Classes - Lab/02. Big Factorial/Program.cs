using System;
using System.Numerics;

class Program
{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        for (int i = 2; i <= N; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}
