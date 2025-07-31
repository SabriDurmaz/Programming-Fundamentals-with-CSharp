using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> distances = Console.ReadLine().Split().Select(int.Parse).ToList();
        int sum = 0;

        while (distances.Count > 0)
        {
            int index = int.Parse(Console.ReadLine());
            int removedElement;

            if (index < 0)
            {
                removedElement = distances[0];
                distances[0] = distances[distances.Count - 1];
            }
            else if (index >= distances.Count)
            {
                removedElement = distances[distances.Count - 1];
                distances[distances.Count - 1] = distances[0];
            }
            else
            {
                removedElement = distances[index];
                distances.RemoveAt(index);
            }

            sum += removedElement;

            for (int i = 0; i < distances.Count; i++)
            {
                if (distances[i] <= removedElement)
                {
                    distances[i] += removedElement;
                }
                else
                {
                    distances[i] -= removedElement;
                }
            }
        }

        Console.WriteLine(sum);
    }
}