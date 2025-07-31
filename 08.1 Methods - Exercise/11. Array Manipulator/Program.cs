List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] parts = input.Split();
    string cmd = parts[0];
    if (cmd == "exchange")
    {
        int index = int.Parse(parts[1]);
        if (index < 0 || index >= nums.Count)
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        List<int> left = nums.Take(index + 1).ToList();
        List<int> right = nums.Skip(index + 1).ToList();
        nums = right.Concat(left).ToList();
    }
    else if (cmd == "max" || cmd == "min")
    {
        string type = parts[1];
        List<int> filtered = type == "even" ? nums.Where(x => x % 2 == 0).ToList() : nums.Where(x => x % 2 != 0).ToList();
        if (!filtered.Any())
        {
            Console.WriteLine("No matches");
            continue;
        }
        int val = cmd == "max" ? filtered.Max() : filtered.Min();
        Console.WriteLine(nums.LastIndexOf(val));
    }
    else if (cmd == "first" || cmd == "last")
    {
        int count = int.Parse(parts[1]);
        string type = parts[2];
        if (count > nums.Count)
        {
            Console.WriteLine("Invalid count");
            continue;
        }
        List<int> filtered = type == "even" ? nums.Where(x => x % 2 == 0).ToList() : nums.Where(x => x % 2 != 0).ToList();
        List<int> result = cmd == "first" ? filtered.Take(count).ToList() : filtered.Reverse<int>().Take(count).Reverse().ToList();
        Console.WriteLine("[" + string.Join(", ", result) + "]");
    }
}
Console.WriteLine("[" + string.Join(", ", nums) + "]");
