Dictionary<string,List<string>>companies=new Dictionary<string,List<string>>();

string input=Console.ReadLine();
while (input != "End")
{
    string[] companyInfo = input.Split("->",StringSplitOptions.RemoveEmptyEntries);
    string companyName = companyInfo[0];
    string iD = companyInfo[1];
    if (!companies.ContainsKey(companyName))
    {
        companies[companyName] = new List<string>();
    }
   if (!companies[companyName].Contains(iD))
    {
        companies[companyName].Add(iD);
    }

    input=Console.ReadLine();
}
foreach (var kvp in companies)
{
    Console.WriteLine(kvp.Key);
    foreach (var item in kvp.Value)
    {
        Console.WriteLine($"--{item}");
    }
}