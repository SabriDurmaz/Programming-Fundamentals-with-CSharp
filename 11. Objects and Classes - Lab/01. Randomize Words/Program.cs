using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        Random rnd = new Random();
        for (int i = 0; i < words.Length; i++)
        {
            int randomIndex = rnd.Next(i, words.Length);
            string temp = words[i];
            words[i] = words[randomIndex];
            words[randomIndex] = temp;
        }

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}
