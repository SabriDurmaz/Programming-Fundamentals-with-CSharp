int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int original = n;
int count = 0;
while (n >= m)
{
    n -= m;
    count++;
    if (n == original / 2 && y != 0)
        n /= y;
}
Console.WriteLine(n);
Console.WriteLine(count);
