using System;

class Program
{
    static void Main()
    {
        char char1 = Console.ReadLine()[0];
        char char2 = Console.ReadLine()[0];
        char char3 = Console.ReadLine()[0];
        string result = $"{char1}{char2}{char3}";
        Console.WriteLine(result);
    }
}
