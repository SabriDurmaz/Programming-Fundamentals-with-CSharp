using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numberStrings = input.Split(' ');
        foreach (var numberString in numberStrings)
        {
            double number = double.Parse(numberString);
            int roundedNumber = (int)Math.Round(number, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{number} => {roundedNumber}");
        }
    }
}
