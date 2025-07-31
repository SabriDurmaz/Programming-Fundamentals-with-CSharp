using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> schedule = Console.ReadLine().Split(", ").ToList();

        string command;
        while ((command = Console.ReadLine()) != "course start")
        {
            string[] parts = command.Split(':');
            string action = parts[0];
            string lessonTitle = parts[1];

            if (action == "Add")
            {
                if (!schedule.Contains(lessonTitle))
                {
                    schedule.Add(lessonTitle);
                }
            }
            else if (action == "Insert")
            {
                int index = int.Parse(parts[2]);
                if (!schedule.Contains(lessonTitle) && index >= 0 && index < schedule.Count)
                {
                    schedule.Insert(index, lessonTitle);
                }
            }
            else if (action == "Remove")
            {
                schedule.Remove(lessonTitle);
                schedule.Remove($"{lessonTitle}-Exercise");
            }
            else if (action == "Swap")
            {
                string secondLessonTitle = parts[2];
                if (schedule.Contains(lessonTitle) && schedule.Contains(secondLessonTitle))
                {
                    int firstIndex = schedule.IndexOf(lessonTitle);
                    int secondIndex = schedule.IndexOf(secondLessonTitle);
                    schedule[firstIndex] = secondLessonTitle;
                    schedule[secondIndex] = lessonTitle;

                    string firstExercise = $"{lessonTitle}-Exercise";
                    string secondExercise = $"{secondLessonTitle}-Exercise";

                    if (schedule.Contains(firstExercise))
                    {
                        schedule.Remove(firstExercise);
                        schedule.Insert(secondIndex + 1, firstExercise);
                    }
                    if (schedule.Contains(secondExercise))
                    {
                        schedule.Remove(secondExercise);
                        schedule.Insert(firstIndex + 1, secondExercise);
                    }
                }
            }
            else if (action == "Exercise")
            {
                if (schedule.Contains(lessonTitle) && !schedule.Contains($"{lessonTitle}-Exercise"))
                {
                    int index = schedule.IndexOf(lessonTitle);
                    schedule.Insert(index + 1, $"{lessonTitle}-Exercise");
                }
                else if (!schedule.Contains(lessonTitle))
                {
                    schedule.Add(lessonTitle);
                    schedule.Add($"{lessonTitle}-Exercise");
                }
            }
        }

        for (int i = 0; i < schedule.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{schedule[i]}");
        }
    }
}