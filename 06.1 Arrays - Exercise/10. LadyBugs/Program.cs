int size = int.Parse(Console.ReadLine());
int[] field = new int[size];
int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
foreach (int index in indexes)
{
    if (index >= 0 && index < size)
        field[index] = 1;
}
string command;
while ((command = Console.ReadLine()) != "end")
{
    string[] parts = command.Split();
    int index = int.Parse(parts[0]);
    string dir = parts[1];
    int fly = int.Parse(parts[2]);
    if (index < 0 || index >= size || field[index] == 0) continue;
    field[index] = 0;
    int pos = index;
    while (true)
    {
        pos = dir == "right" ? pos + fly : pos - fly;
        if (pos < 0 || pos >= size) break;
        if (field[pos] == 0)
        {
            field[pos] = 1;
            break;
        }
    }
}
Console.WriteLine(string.Join(" ", field));
