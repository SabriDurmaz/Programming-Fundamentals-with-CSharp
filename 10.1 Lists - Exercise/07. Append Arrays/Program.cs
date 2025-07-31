using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] arrays = Console.ReadLine().Split('|');
        List<int> result = new List<int>();

        for (int i = arrays.Length - 1; i >= 0; i--)
        {
            int[] numbers = arrays[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            result.AddRange(numbers);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}