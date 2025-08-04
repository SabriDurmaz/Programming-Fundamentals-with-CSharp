using System;
using System.Collections.Generic;
using System.Linq;

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
            Student newStudent = new Student(studentInfo[0], studentInfo[1], int.Parse(studentInfo[2]), studentInfo[3]);

            Student existingStudent = students.FirstOrDefault(s => s.FirstName == newStudent.FirstName && s.LastName == newStudent.LastName);

            if (existingStudent != null)
            {
                existingStudent.Age = newStudent.Age;
                existingStudent.Hometown = newStudent.Hometown;
            }
            else
            {
                students.Add(newStudent);
            }
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