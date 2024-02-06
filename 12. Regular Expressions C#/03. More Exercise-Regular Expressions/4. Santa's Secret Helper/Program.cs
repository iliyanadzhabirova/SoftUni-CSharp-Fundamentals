using System.Text.RegularExpressions;

int key = int.Parse(Console.ReadLine());

List<string> goodChildren = new List<string>();

string input = "";
while ((input = Console.ReadLine()) != "end")
{
    string decryptedMessage = "";
    foreach (char c in input)
    {
        decryptedMessage += (char)(c - key);
    }

    Match nameMatch = Regex.Match(decryptedMessage, @"(?<=@)[A-Za-z]+");
    Match behaviorMatch = Regex.Match(decryptedMessage, @"(?<=!)[GN](?=!)");

    if (nameMatch.Success && behaviorMatch.Success && behaviorMatch.Value == "G")
    {
        string name = nameMatch.Value;

        if (decryptedMessage.Contains(name) && !goodChildren.Contains(name))
        {
            goodChildren.Add(name);
        }
    }
}

foreach (var child in goodChildren)
{
    Console.WriteLine(child);
}