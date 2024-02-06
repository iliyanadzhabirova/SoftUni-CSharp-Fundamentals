using System.Text.RegularExpressions;

string dates=Console.ReadLine();

string pattern = @"(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

MatchCollection matches = Regex.Matches(dates, pattern);

foreach (Match match in matches)
{
    Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
}