using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> data = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        string command;
        while ((command = Console.ReadLine()) != "3:1")
        {
            string[] parts = command.Split();
            if (parts[0] == "merge")
            {
                int startIndex = int.Parse(parts[1]);
                int endIndex = int.Parse(parts[2]);
                startIndex = Math.Max(0, startIndex);
                endIndex = Math.Min(data.Count - 1, endIndex);

                if (startIndex >= endIndex)
                {
                    continue;
                }

                string merged = string.Join("", data.GetRange(startIndex, endIndex - startIndex + 1));
                data.RemoveRange(startIndex, endIndex - startIndex + 1);
                data.Insert(startIndex, merged);
            }
            else if (parts[0] == "divide")
            {
                int index = int.Parse(parts[1]);
                int partitions = int.Parse(parts[2]);
                string element = data[index];
                data.RemoveAt(index);

                int partLength = element.Length / partitions;
                List<string> divided = new List<string>();

                for (int i = 0; i < partitions - 1; i++)
                {
                    divided.Add(element.Substring(i * partLength, partLength));
                }
                divided.Add(element.Substring((partitions - 1) * partLength));

                data.InsertRange(index, divided);
            }
        }

        Console.WriteLine(string.Join(" ", data));
    }
}