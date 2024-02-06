using System.Text.RegularExpressions;

string foodInfo=Console.ReadLine();
string pattern = @"(#|\|)(?<food>[a-zA-Z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)";
MatchCollection matches=Regex.Matches(foodInfo, pattern);
int caloriesPerDay = 2000;
int totalCalories = 0;
foreach (Match match in matches)
{
    int caloriesPerMatch =int.Parse( match.Groups["calories"].Value);
    totalCalories += caloriesPerMatch;

}
int days = 0;
if (totalCalories > caloriesPerDay)
{
    days = totalCalories / caloriesPerDay;
}

Console.WriteLine($"You have food to last you for: {days} days!");
if (days > 0)
{
    foreach (Match match in matches)
    {
        string food = match.Groups["food"].Value;
        string date = match.Groups["date"].Value;
        string calories = match.Groups["calories"].Value;
        Console.WriteLine($"Item: {food}, Best before: {date}, Nutrition: {calories}");
    }
}