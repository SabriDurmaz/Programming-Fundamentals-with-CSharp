int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    int sum = i.ToString().Sum(c => c - '0');
    bool hasOdd = i.ToString().Any(c => (c - '0') % 2 == 1);
    if (sum % 8 == 0 && hasOdd)
    {
        Console.WriteLine(i);
    }
}
