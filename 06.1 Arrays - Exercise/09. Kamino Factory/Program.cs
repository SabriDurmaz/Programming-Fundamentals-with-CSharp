int length = int.Parse(Console.ReadLine());
string input;
int bestSum = 0, bestIndex = 0, bestStartIndex = length, bestLen = 0, sample = 0;
int[] bestSeq = new int[length];
while ((input = Console.ReadLine()) != "Clone them!")
{
    string[] parts = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries);
    int[] sequence = parts.Select(int.Parse).ToArray();
    int currSum = sequence.Sum();
    int currLen = 0, currBestLen = 0, currStart = 0;
    for (int i = 0; i < sequence.Length; i++)
    {
        if (sequence[i] == 1)
        {
            currLen++;
            if (currLen > currBestLen)
            {
                currBestLen = currLen;
                currStart = i - currLen + 1;
            }
        }
        else
        {
            currLen = 0;
        }
    }
    sample++;
    if (currBestLen > bestLen ||
        (currBestLen == bestLen && currStart < bestStartIndex) ||
        (currBestLen == bestLen && currStart == bestStartIndex && currSum > bestSum))
    {
        bestLen = currBestLen;
        bestStartIndex = currStart;
        bestSum = currSum;
        bestIndex = sample;
        Array.Copy(sequence, bestSeq, length);
    }
}
Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestSum}.");
Console.WriteLine(string.Join(" ", bestSeq));
