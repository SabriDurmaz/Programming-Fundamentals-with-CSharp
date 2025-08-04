using System;
using System.Collections.Generic;

class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }

    public Song(string typeList, string name, string time)
    {
        TypeList = typeList;
        Name = name;
        Time = time;
    }
}

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split('_');
            songs.Add(new Song(input[0], input[1], input[2]));
        }

        string targetTypeList = Console.ReadLine();

        if (targetTypeList == "all")
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
        else
        {
            foreach (Song song in songs)
            {
                if (song.TypeList == targetTypeList)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}