using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            int sumOfDigits = CalculateSumOfDigits(i);
            bool isSpecial = (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11);
            Console.WriteLine($"{i} -> {isSpecial}");
        }
    }

    static int CalculateSumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }
}
