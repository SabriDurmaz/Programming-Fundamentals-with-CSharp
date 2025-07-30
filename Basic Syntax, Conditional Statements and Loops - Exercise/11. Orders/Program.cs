int orders = int.Parse(Console.ReadLine());
decimal total = 0;

for (int i = 0; i < orders; i++)
{
    decimal price = decimal.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int count = int.Parse(Console.ReadLine());

    decimal current = days * count * price;
    total += current;

    Console.WriteLine($"The price for the coffee is: ${current:F2}");
}

Console.WriteLine($"Total: ${total:F2}");