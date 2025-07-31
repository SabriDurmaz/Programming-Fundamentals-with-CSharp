string[] arr1 = Console.ReadLine().Split();
string[] arr2 = Console.ReadLine().Split();
foreach (string item in arr2)
{
    if (arr1.Contains(item))
    {
        Console.Write(item + " ");
    }
}
