using System;
using System.Collections.Generic;
using System.Linq;

class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }

    public Truck(string brand, string model, int weight)
    {
        Brand = brand;
        Model = model;
        Weight = weight;
    }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }

    public Car(string brand, string model, int horsePower)
    {
        Brand = brand;
        Model = model;
        HorsePower = horsePower;
    }
}

class Catalog
{
    public List<Car> Cars { get; set; }
    public List<Truck> Trucks { get; set; }

    public Catalog()
    {
        Cars = new List<Car>();
        Trucks = new List<Truck>();
    }

    public void PrintCatalog()
    {
        Console.WriteLine("Cars:");
        foreach (var car in Cars.OrderBy(c => c.Brand))
        {
            Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
        }

        Console.WriteLine("Trucks:");
        foreach (var truck in Trucks.OrderBy(t => t.Brand))
        {
            Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
        }
    }
}

class Program
{
    static void Main()
    {
        Catalog catalog = new Catalog();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] parts = input.Split('/');
            string type = parts[0];

            if (type == "Car")
            {
                string brand = parts[1];
                string model = parts[2];
                int horsePower = int.Parse(parts[3]);

                Car car = new Car(brand, model, horsePower);
                catalog.Cars.Add(car);
            }
            else if (type == "Truck")
            {
                string brand = parts[1];
                string model = parts[2];
                int weight = int.Parse(parts[3]);

                Truck truck = new Truck(brand, model, weight);
                catalog.Trucks.Add(truck);
            }
        }
        catalog.PrintCatalog();
    }
}
