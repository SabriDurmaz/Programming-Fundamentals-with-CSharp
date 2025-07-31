using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] parts = command.Split();
            if (parts[0] == "Delete")
            {
                int element = int.Parse(parts[1]);
                numbers.RemoveAll(x => x == element);
            }
            else if (parts[0] == "Insert")
            {
                int element = int.Parse(parts[1]);
                int position = int.Parse(parts[2]);
                numbers.Insert(position, element);
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}