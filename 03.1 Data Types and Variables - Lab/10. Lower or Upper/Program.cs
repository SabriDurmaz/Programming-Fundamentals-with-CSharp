using System;

class Program
{
    static void Main()
    {
        char inputChar = Console.ReadLine()[0];
        if (char.IsUpper(inputChar))
        {
            Console.WriteLine("upper-case");
        }
        else if (char.IsLower(inputChar))
        {
            Console.WriteLine("lower-case");
        }
        else
        {
            Console.WriteLine("not a letter");
        }
    }
}
