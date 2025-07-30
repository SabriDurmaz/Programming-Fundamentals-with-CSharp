using System;

class Program
{
    static void Main()
    {
        const double conversionRate = 1.31;
        double pounds = double.Parse(Console.ReadLine());
        double dollars = pounds * conversionRate;
        Console.WriteLine($"{dollars:F3}");
    }
}
