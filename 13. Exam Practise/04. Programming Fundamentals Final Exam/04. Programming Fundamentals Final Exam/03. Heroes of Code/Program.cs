namespace _03._Heroes_of_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int>heroesWithHP = new Dictionary<string,int>();
            Dictionary<string,int>heroesWithMP=new Dictionary<string,int>();
            int n=int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[]heroArgs=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string heroName = heroArgs[0];
                int healthPoints = int.Parse(heroArgs[1]);
                int manaPoints = int.Parse(heroArgs[2]);

                heroesWithHP[heroName]=healthPoints;
                heroesWithMP[heroName]=manaPoints;
            }
            string command=Console.ReadLine();
            while (command!="End")
            {
                string[] commandArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArgs[0];
                string heroName = commandArgs[1];

                if (commandType== "CastSpell")
                {
                    int manaPointsNeeded = int.Parse(commandArgs[2]);
                    string spellName = commandArgs[3];

                    if (heroesWithMP[heroName]>=manaPointsNeeded)
                    {
                        heroesWithMP[heroName]-=manaPointsNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesWithMP[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (commandType== "TakeDamage")
                {
                    int damage = int.Parse(commandArgs[2]);
                    string attacker = commandArgs[3];

                    heroesWithHP[heroName] -= damage;
                    if (heroesWithHP[heroName]>0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesWithHP[heroName]} HP left!");
                    }
                    else
                    {
                        heroesWithHP.Remove(heroName);
                        heroesWithMP.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (commandType == "Recharge")
                {
                    int amount = int.Parse(commandArgs[2]);

                    if (heroesWithMP[heroName] + amount > 200)
                    {
                        amount = 200 - heroesWithMP[heroName];                       
                    }
                    heroesWithMP[heroName] += amount;
                    Console.WriteLine($"{heroName} recharged for {amount} MP!");
                }
                else if (commandType == "Heal")
                {
                    int amount = int.Parse(commandArgs[2]);
                   
                    if (heroesWithHP[heroName] +amount > 100)
                    {
                        amount= 100 - heroesWithHP[heroName];
                    }
                    heroesWithHP[heroName] += amount;
                    Console.WriteLine($"{heroName} healed for {amount} HP!");
                }

                command = Console.ReadLine();
            }
            foreach (var kvp in heroesWithMP)
            {
                string heroName = kvp.Key;
                int manaPoints=kvp.Value;
                int healthPoints = heroesWithHP[heroName];

                Console.WriteLine($"{heroName}");
                Console.WriteLine($"  HP: {healthPoints}");
                Console.WriteLine($"  MP: {manaPoints}");
            }
        }
    }
}