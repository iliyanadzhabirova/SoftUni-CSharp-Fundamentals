using System.Text.RegularExpressions;

var demons = Console.ReadLine().Split(new[] {' ',',' },StringSplitOptions.RemoveEmptyEntries)
    .Select(demonName=>new Demon(demonName))
    .OrderBy(demon=>demon.Name);


foreach (var demon in demons)
{
    Console.WriteLine($"{demon.Name} - {demon.HealthPoints} health, {demon.DamagePoints:f2} damage");
}
class Demon
{
    public string Name { get; set; }
    public int HealthPoints { get; set; }
    public double DamagePoints { get; set; }

    public  Demon(string name)
    {
        Name = name;
        HealthPoints = CalculateHealth(name);
        DamagePoints = CalculateDamage(name);
    }
    private int CalculateHealth(string name)
    {
        string pattern = @"[^\+\-\*\/\.\,0-9 ]";
        MatchCollection matches=Regex.Matches(name,pattern);
        int health = 0;
        foreach(Match match in matches) 
        {
        char currentChar=char.Parse(match.Value);
        health += currentChar;
        }
        return health;
    }

    private double CalculateDamage(string name)
    {
        string pattern = @"-?\d+\.?\d*";
        var matches=Regex.Matches(name,pattern);
        var baseDamage=matches.Select(d=>double.Parse(d.Value)).Sum();
        foreach(char c in name)
        {
            if (c =='*')
            {
                baseDamage *= 2;
            }
            else if (c =='/')
            {
                baseDamage/= 2;
            }
        }
       return baseDamage;
    }
}
