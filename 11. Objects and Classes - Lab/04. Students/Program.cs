using System;
using System.Collections.Generic;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Hometown { get; set; }

    public Student(string firstName, string lastName, int age, string hometown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Hometown = hometown;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            string[] studentInfo = input.Split(' ');
            students.Add(new Student(studentInfo[0], studentInfo[1], int.Parse(studentInfo[2]), studentInfo[3]));
        }

        string targetCity = Console.ReadLine();

        foreach (Student student in students)
        {
            if (student.Hometown == targetCity)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}