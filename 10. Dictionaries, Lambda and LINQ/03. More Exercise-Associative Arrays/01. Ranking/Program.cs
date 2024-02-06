Dictionary<string, string> contestDictionary = new Dictionary<string, string>();
SortedDictionary<string, Dictionary<string, int>> usersDictionary = new SortedDictionary<string, Dictionary<string, int>>();
string input = string.Empty;
string[] separator = { "=>" };
while ((input = Console.ReadLine()) != "end of contests")
{
    string[] str = input.Split(':');
    string contest = str[0];
    string password = str[1];
    contestDictionary.Add(contest, password);
}
string inputUsers = string.Empty;
while ((inputUsers = Console.ReadLine()) != "end of submissions")
{
    string[] str2 = inputUsers.Split(separator, StringSplitOptions.None);
    string contestUsers = str2[0];
    string passwordUsers = str2[1];
    string name = str2[2];
    int points = int.Parse(str2[3]);
    if (contestDictionary.ContainsKey(contestUsers)
        && contestDictionary.ContainsValue(passwordUsers))
    {
        if (usersDictionary.ContainsKey(name) == false)
        {
            usersDictionary.Add(name, new Dictionary<string, int>());
            usersDictionary[name].Add(contestUsers, points);
        }
        if (usersDictionary[name].ContainsKey(contestUsers))
        {
            if (usersDictionary[name][contestUsers] < points)
            {
                usersDictionary[name][contestUsers] = points;
            }
        }
        else
        {
            usersDictionary[name].Add(contestUsers, points);
        }
    }

}
Dictionary<string, int> usernameTotalPoints = new Dictionary<string, int>();
foreach (var kvp in usersDictionary)
{
    usernameTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
}
string bestName = usernameTotalPoints
    .Keys
    .Max();
int bestPoints = usernameTotalPoints
    .Values
    .Max();

foreach (var kvp in usernameTotalPoints)
{
    if (kvp.Value == bestPoints)
    {
        Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

    }
}
Console.WriteLine("Ranking:");
foreach (var name in usersDictionary)
{
    Dictionary<string, int> dict = name.Value;
    dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
    Console.WriteLine("{0}", name.Key);
    foreach (var kvp in dict)
    {
        Console.WriteLine("#  {0} -> {1}", kvp.Key, kvp.Value);
    }

}