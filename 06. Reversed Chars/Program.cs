using System;

class Program
{
    static void Main()
    {
        string line1 = Console.ReadLine();
        string line2 = Console.ReadLine();
        string line3 = Console.ReadLine();
        string[] lines = { line1, line2, line3 };
        Array.Reverse(lines);
        string reversedOutput = string.Join(" ", lines);
        Console.WriteLine(reversedOutput);
    }
}
