using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numberStrings = input.Split(' ');
        int[] numbers = Array.ConvertAll(numberStrings, int.Parse);
        int sumEven = 0;
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                sumEven += number;
            }
        }
        Console.WriteLine(sumEven);
    }
}
