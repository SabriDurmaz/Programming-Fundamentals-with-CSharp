double total = 0;
string input;

while ((input = Console.ReadLine()) != "Start")
{
    double coin = double.Parse(input);
    if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
        total += coin;
    else
        Console.WriteLine($"Cannot accept {coin}");
}

while ((input = Console.ReadLine()) != "End")
{
    double price = 0;
    if (input == "Nuts") price = 2.0;
    else if (input == "Water") price = 0.7;
    else if (input == "Crisps") price = 1.5;
    else if (input == "Soda") price = 0.8;
    else if (input == "Coke") price = 1.0;
    else
    {
        Console.WriteLine("Invalid product");
        continue;
    }

    if (total >= price)
    {
        total -= price;
        Console.WriteLine($"Purchased {input.ToLower()}");
    }
    else Console.WriteLine("Sorry, not enough money");
}

Console.WriteLine($"Change: {total:F2}");