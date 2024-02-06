using System.Numerics;
using System.Text.RegularExpressions;

string text = Console.ReadLine();
BigInteger coolTreshold=CalculateCoolThreshold(text);

string pattern = @"((\*\*)|(\:\:))(?<emojis>[A-Z][a-z]{2,})(\1)";
Regex regex=new Regex(pattern);
MatchCollection matches = regex.Matches(text);

Console.WriteLine($"Cool threshold: {coolTreshold}");
Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
foreach (Match match in matches)
{
    string emojiWord = match.Groups["emojis"].Value;
    long coolness = CalculateCoolness(emojiWord);
    if (coolness >= coolTreshold)
    {
        Console.WriteLine($"{match.Value} ");
    }
}

static BigInteger CalculateCoolThreshold(string inputText)
{
    BigInteger coolTreshold = 1;
    foreach (char ch in inputText)
    {
        if (char.IsDigit(ch))
        {
            int digit = (int)ch - 48;

            coolTreshold *= digit;

        }
    }
    return coolTreshold;
}
static long CalculateCoolness(string emojiWord)
{
    long coolness = 0;
    foreach (char ch in emojiWord)
    {
        coolness += (int)ch;
    }
    return coolness;
}

