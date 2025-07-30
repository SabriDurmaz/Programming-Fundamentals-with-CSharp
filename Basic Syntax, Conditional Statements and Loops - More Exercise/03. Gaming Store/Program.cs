using System;

class Program
{
    static void Main()
    {
        double balance = double.Parse(Console.ReadLine());
        double totalSpent = 0;

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "Game Time")
            {
                Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${balance:F2}");
                break;
            }

            double price = GetGamePrice(command);

            if (price == -1)
            {
                Console.WriteLine("Not Found");
            }
            else if (price > balance)
            {
                Console.WriteLine("Too Expensive");
            }
            else
            {
                balance -= price;
                totalSpent += price;
                Console.WriteLine($"Bought {command}");

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
        }
    }

    static double GetGamePrice(string gameName)
    {
        switch (gameName)
        {
            case "OutFall 4": return 39.99;
            case "CS: OG": return 15.99;
            case "Zplinter Zell": return 19.99;
            case "Honored 2": return 59.99;
            case "RoverWatch": return 29.99;
            case "RoverWatch Origins Edition": return 39.99;
            default: return -1;
        }
    }
}
