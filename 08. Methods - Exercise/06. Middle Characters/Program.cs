string input = Console.ReadLine();
int mid = input.Length / 2;
if (input.Length % 2 == 0)
{
    Console.WriteLine(input.Substring(mid - 1, 2));
}
else
{
    Console.WriteLine(input[mid]);
}
