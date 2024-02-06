List<int> numbers = new List<int> { 10, 20, 30, 40 };

Console.WriteLine(numbers.Min());
Console.WriteLine(numbers.Max());
Console.WriteLine(numbers.Sum());
Console.WriteLine(numbers.Average());

numbers = numbers // 10, 20, 30, 40
    .Where(x => x > 20) // 30, 40
    .Select(x => x / 2) //15, 20
    .ToList(); // List<int> { 15, 20 }

Console.WriteLine(string.Join(" ", numbers));

Dictionary<string, List<string>> wordSyn =
    new Dictionary<string, List<string>>();

if (!wordSyn.ContainsKey("smart"))
{
    wordSyn.Add("smart", new List<string>());
}

wordSyn["smart"].Add("clever");

wordSyn["smart"].Remove("cleaver"); //True or False

foreach (var (key, value) in wordSyn)
{
    string currentKey = key;
    List<string> currentWords = value;
}