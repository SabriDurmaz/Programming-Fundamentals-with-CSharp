using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string info;
        Dictionary<string, Student> studentsDictionary = new Dictionary<string, Student>();

        while ((info = Console.ReadLine()) != "End")
        {
            string[] studentInfo = info.Split();

            string name = studentInfo[0];
            string studentId = studentInfo[1];
            int age = int.Parse(studentInfo[2]);

            if (studentsDictionary.ContainsKey(studentId))
            {
                studentsDictionary[studentId].Name = name;
                studentsDictionary[studentId].Age = age;
            }
            else
            {
                Student newStudent = new Student(name, studentId, age);
                studentsDictionary.Add(studentId, newStudent);
            }
        }

        foreach (var student in studentsDictionary.Values.OrderBy(s => s.Age))
        {
            Console.WriteLine($"{student.Name} with ID: {student.StudentID} is {student.Age} years old.");
        }
    }
}

public class Student
{
    public Student(string name, string studentId, int age)
    {
        Name = name;
        StudentID = studentId;
        Age = age;
    }

    public string Name { get; set; }
    public string StudentID { get; set; }
    public int Age { get; set; }
}