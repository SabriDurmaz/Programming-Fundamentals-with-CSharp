int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
long Factorial(int x)
{
    long result = 1;
    for (int i = 2; i <= x; i++)
    {
        result *= i;
    }
    return result;
}
double result = (double)Factorial(a) / Factorial(b);
Console.WriteLine($"{result:F2}");
