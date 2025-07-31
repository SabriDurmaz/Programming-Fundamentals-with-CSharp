using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
        {
            int firstCard = firstPlayer[0];
            int secondCard = secondPlayer[0];

            if (firstCard > secondCard)
            {
                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
                firstPlayer.Add(firstCard);
                firstPlayer.Add(secondCard);
            }
            else if (secondCard > firstCard)
            {
                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
                secondPlayer.Add(secondCard);
                secondPlayer.Add(firstCard);
            }
            else
            {
                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
            }
        }

        if (firstPlayer.Count > 0)
        {
            Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
        }
        else
        {
            Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
        }
    }
}