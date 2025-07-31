int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int maxLen = 0, currLen = 1, maxIndex = 0;
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] == arr[i - 1])
    {
        currLen++;
        if (currLen > maxLen)
        {
            maxLen = currLen;
            maxIndex = i - maxLen + 1;
        }
    }
    else
    {
        currLen = 1;
    }
}
if (maxLen == 0)
{
    Console.WriteLine(arr[0]);
}
else
{
    Console.WriteLine(string.Join(" ", arr.Skip(maxIndex).Take(maxLen)));
}
