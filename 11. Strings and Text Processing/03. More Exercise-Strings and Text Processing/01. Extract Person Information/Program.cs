int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    int nameStart = input.IndexOf('@') + 1;
    int nameEnd = input.IndexOf('|');
    string name = input.Substring(nameStart, nameEnd - nameStart);

    int ageStart = input.IndexOf('#') + 1;
    int ageEnd = input.IndexOf('*');
    int age = int.Parse(input.Substring(ageStart, ageEnd - ageStart));

    Console.WriteLine($"{name} is {age} years old.");
}