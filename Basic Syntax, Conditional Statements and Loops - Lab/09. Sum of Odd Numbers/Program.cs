using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int oddNumber = 2 * i + 1;
            Console.WriteLine(oddNumber);
            sum += oddNumber;
        }

        Console.WriteLine($"Sum: {sum}");
    }
}
