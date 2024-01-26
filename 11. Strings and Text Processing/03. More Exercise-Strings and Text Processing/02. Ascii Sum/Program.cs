char first = char.Parse(Console.ReadLine());
char second = char.Parse(Console.ReadLine());
string input = Console.ReadLine();

int sum = 0;
for (int i = 0; i < input.Length; i++)
{
    char current = input[i];
    if (current > first && current < second)
    {
        sum += (int)current;
    }
}

Console.WriteLine(sum);