using System;
class Program
{
    static void Main()
    {
        string[] daysOfWeek = {
            "Invalid day!",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };
        int dayNumber = int.Parse(Console.ReadLine());
        if (dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine(daysOfWeek[dayNumber]);
        }
        else
        {
            Console.WriteLine("Invalid day!");
        }
    }
}
