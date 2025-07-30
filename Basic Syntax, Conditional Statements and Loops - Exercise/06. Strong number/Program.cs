int number = int.Parse(Console.ReadLine());
int sum = 0, original = number;

while (number > 0)
{
    int digit = number % 10;
    int fact = 1;
    for (int i = 1; i <= digit; i++) fact *= i;
    sum += fact;
    number /= 10;
}

Console.WriteLine(sum == original ? "yes" : "no");
