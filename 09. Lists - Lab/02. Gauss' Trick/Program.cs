using System;
using System.Collections.Generic;

class GaussTrick
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] inputArray = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<int> inputList = new List<int>();
        foreach (var str in inputArray)
        {
            inputList.Add(int.Parse(str));
        }

        List<int> newList = new List<int>();
        int i = 0;

        while (i < inputList.Count / 2)
        {
            int sum = inputList[i] + inputList[inputList.Count - 1 - i];
            newList.Add(sum);
            i++;
        }

        if (inputList.Count % 2 != 0)
        {
            newList.Add(inputList[inputList.Count / 2]);
        }

        Console.WriteLine(string.Join(" ", newList));
    }
}
