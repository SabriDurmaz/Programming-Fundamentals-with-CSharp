using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Vehicle> vehiclesList = new List<Vehicle>();
        string info;
        while ((info = Console.ReadLine()) != "End")
        {
            string[] infoArray = info.Split();
            string type = infoArray[0];
            string model = infoArray[1];
            string color = infoArray[2];
            int horsePower = int.Parse(infoArray[3]);

            Vehicle currentVehicle = new Vehicle(type, model, color, horsePower);
            vehiclesList.Add(currentVehicle);
        }

        string command;
        while ((command = Console.ReadLine()) != "Close the Catalogue")
        {
            string inputInfo = command;
            var vehicle = vehiclesList.FirstOrDefault(v => v.Model == inputInfo);

            if (vehicle != null)
            {
                Console.WriteLine(vehicle);
            }
        }

        List<Vehicle> carsList = vehiclesList.Where(v => v.Type == "car").ToList();
        List<Vehicle> trucksList = vehiclesList.Where(v => v.Type == "truck").ToList();

        double carsAverageHorsePwr = CalculateAverageHorsePower(carsList);
        double trucksAverageHorsePwr = CalculateAverageHorsePower(trucksList);

        Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePwr:f2}.");
        Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsePwr:f2}.");
    }

    private static double CalculateAverageHorsePower(List<Vehicle> vehicles)
    {
        if (vehicles.Count == 0)
        {
            return 0.00;
        }

        double totalHorsePower = vehicles.Sum(v => v.HorsePower);
        return totalHorsePower / vehicles.Count;
    }
}

public class Vehicle
{
    public Vehicle(string type, string model, string color, int horsePower)
    {
        Type = type;
        Model = model;
        Color = color;
        HorsePower = horsePower;
    }

    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int HorsePower { get; set; }

    public override string ToString()
    {
        return $"Type: {Type[0].ToString().ToUpper() + Type.Substring(1)}\nModel: {Model}\nColor: {Color}\nHorsepower: {HorsePower}";
    }
}
