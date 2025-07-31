using System;

public class DataTypes
{
    public static void Main(string[] args)
    {
        string command = Console.ReadLine();
        string input = Console.ReadLine();

        switch (command)
        {
            case "int":
                if (int.TryParse(input, out int intValue))
                {
                    MultiplyBy2(intValue);
                }
                break;
            case "real":
                if (double.TryParse(input, out double doubleValue))
                {
                    RealMultiplyAndFormat(doubleValue);
                }
                break;
            case "string":
                StringFormattedPrint(input);
                break;
        }
    }

    private static void MultiplyBy2(int inp)
    {
        inp *= 2;
        Console.WriteLine(inp);
    }

    private static void RealMultiplyAndFormat(double num)
    {
        num *= 1.5;
        Console.WriteLine(num.ToString("F2"));
    }

    private static void StringFormattedPrint(string input)
    {
        Console.WriteLine($"${input}$");
    }
}
