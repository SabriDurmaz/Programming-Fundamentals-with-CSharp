using System;
using System.Collections.Generic;
using System.Linq;

class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Item(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class Box
{
    public int SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal Price { get; set; }

    public Box(int serialNumber, Item item, int itemQuantity)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = itemQuantity;
        Price = itemQuantity * item.Price;
    }
}

class Program
{
    static void Main()
    {
        List<Box> boxes = new List<Box>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            string[] boxInfo = input.Split(' ');
            int serialNumber = int.Parse(boxInfo[0]);
            string itemName = boxInfo[1];
            int itemQuantity = int.Parse(boxInfo[2]);
            decimal itemPrice = decimal.Parse(boxInfo[3]);

            Item item = new Item(itemName, itemPrice);
            Box box = new Box(serialNumber, item, itemQuantity);
            boxes.Add(box);
        }

        boxes = boxes.OrderByDescending(box => box.Price).ToList();

        foreach (Box box in boxes)
        {
            Console.WriteLine(box.SerialNumber);
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.Price:F2}");
        }
    }
}