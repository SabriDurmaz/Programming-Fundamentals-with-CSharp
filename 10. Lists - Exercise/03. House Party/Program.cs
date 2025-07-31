using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> guests = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split();
            string name = parts[0];

            if (parts[2] == "going!")
            {
                if (guests.Contains(name))
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else
                {
                    guests.Add(name);
                }
            }
            else if (parts[2] == "not")
            {
                if (guests.Contains(name))
                {
                    guests.Remove(name);
                }
                else
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
            }
        }

        foreach (string guest in guests)
        {
            Console.WriteLine(guest);
        }
    }
}