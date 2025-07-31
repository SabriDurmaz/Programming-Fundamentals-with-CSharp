using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int bombNumber = bombInfo[0];
        int power = bombInfo[1];

        while (numbers.Contains(bombNumber))
        {
            int bombIndex = numbers.IndexOf(bombNumber);
            int leftBound = Math.Max(0, bombIndex - power);
            int rightBound = Math.Min(numbers.Count - 1, bombIndex + power);
            numbers.RemoveRange(leftBound, rightBound - leftBound + 1);
        }

        Console.WriteLine(numbers.Sum());
    }
}