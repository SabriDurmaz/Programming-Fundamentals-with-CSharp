using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] parts = command.Split();
            if (parts[0] == "Add")
            {
                int number = int.Parse(parts[1]);
                numbers.Add(number);
            }
            else if (parts[0] == "Insert")
            {
                int number = int.Parse(parts[1]);
                int index = int.Parse(parts[2]);
                if (index < 0 || index >= numbers.Count)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    numbers.Insert(index, number);
                }
            }
            else if (parts[0] == "Remove")
            {
                int index = int.Parse(parts[1]);
                if (index < 0 || index >= numbers.Count)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    numbers.RemoveAt(index);
                }
            }
            else if (parts[0] == "Shift" && parts[1] == "left")
            {
                int count = int.Parse(parts[2]);
                for (int i = 0; i < count; i++)
                {
                    int first = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Add(first);
                }
            }
            else if (parts[0] == "Shift" && parts[1] == "right")
            {
                int count = int.Parse(parts[2]);
                for (int i = 0; i < count; i++)
                {
                    int last = numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Insert(0, last);
                }
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}