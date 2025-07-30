using System;
class Program
{
    static void Main()
    {
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());

        double[] numbers = { num1, num2, num3 };
        Array.Sort(numbers);
        Array.Reverse(numbers);

        foreach (double number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
