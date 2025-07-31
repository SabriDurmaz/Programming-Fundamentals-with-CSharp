int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
bool found = false;
for (int i = 0; i < arr.Length; i++)
{
    int left = arr.Take(i).Sum();
    int right = arr.Skip(i + 1).Sum();
    if (left == right)
    {
        Console.WriteLine(i);
        found = true;
        break;
    }
}
if (!found) Console.WriteLine("no");
