int n = int.Parse(Console.ReadLine());
string biggestModel = "";
double maxVolume = 0;
for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());
    double volume = Math.PI * radius * radius * height;
    if (volume > maxVolume)
    {
        maxVolume = volume;
        biggestModel = model;
    }
}
Console.WriteLine(biggestModel);
