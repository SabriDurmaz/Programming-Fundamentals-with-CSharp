char a = char.Parse(Console.ReadLine());
char b = char.Parse(Console.ReadLine());
if (a > b)
{
    char temp = a;
    a = b;
    b = temp;
}
for (char c = (char)(a + 1); c < b; c++)
{
    Console.Write(c + " ");
}
