using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] strings = input.Split(' ');
        Array.Reverse(strings);
        Console.WriteLine(string.Join(" ", strings));
    }
}
