string input;
bool IsPalindrome(string s) => s == new string(s.Reverse().ToArray());
while ((input = Console.ReadLine()) != "END")
{
    Console.WriteLine(IsPalindrome(input).ToString().ToLower());
}
