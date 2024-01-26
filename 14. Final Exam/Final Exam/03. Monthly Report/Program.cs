Dictionary<string, double> distributions = new Dictionary<string, double>();
Dictionary<string, double> clients = new Dictionary<string, double>();

string input = Console.ReadLine();
double moneySpendTotal = 0;
double moneyEarnedTotal = 0;
while (input!="End")
{
    string[] commandInfo = input.Split();
    string command = commandInfo[0];
    if (command=="Deliver")
    {
        string distributorName = commandInfo[1];
        double moneySpend = double.Parse(commandInfo[2]);
        if (!distributions.ContainsKey(distributorName))
        {
            distributions[distributorName] = moneySpend;
            moneySpendTotal += moneySpend;
        }
        else
        {
            distributions[distributorName]+= moneySpend;
            moneySpendTotal += moneySpend;
        }
    }
    else if (command=="Return")
    {
        string distributorName = commandInfo[1];
        double moneyReturned= double.Parse(commandInfo[2]);
        if (distributions.ContainsKey(distributorName)&&moneyReturned<=moneySpendTotal)
        {
            distributions[distributorName] -= moneyReturned;
            moneySpendTotal -= moneyReturned;
            if (distributions[distributorName]<=0)
            {
                distributions.Remove(distributorName);
            }
        }

    }
    else if (command=="Sell")
    {
        string clientName = commandInfo[1];
        double moneyEarned= double.Parse(commandInfo[2]);
        if (!clients.ContainsKey(clientName))
        {
            clients[clientName]= moneyEarned;
            moneyEarnedTotal += moneyEarned;
        }
        else
        {
            clients[clientName] += moneyEarned;
            moneyEarnedTotal += moneyEarned;
        }
    }

    input = Console.ReadLine();
}
foreach (var kvp in clients)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value:f2}");
}
Console.WriteLine("-----------");
foreach (var kvp in distributions)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value:f2}");
}
Console.WriteLine("-----------");
Console.WriteLine($"Total Income: {moneyEarnedTotal:f2}");