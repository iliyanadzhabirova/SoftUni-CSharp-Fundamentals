using System.Text.RegularExpressions;

string pattern = @"(^|\s)[A-Za-z0-9][\w\-\.]*[A-Za-z0-9]@[A-Za-z]+([.-][A-Za-z]+)+\b";
string input=Console.ReadLine();

MatchCollection matches = Regex.Matches(input, pattern);

foreach (Match match in matches)
{
    Console.WriteLine(match);
}