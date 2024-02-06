using static System.Net.Mime.MediaTypeNames;
using System;

namespace Problem_3___Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int> pirateShip=Console.ReadLine().Split(">").Select(int.Parse).ToList();
          List<int> warship = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealth=int.Parse(Console.ReadLine());
            string command=Console.ReadLine();
            while (command!="Retire")
            {
                string[] commandInfo = command.Split();
                if (commandInfo[0]=="Fire")
                {
                    int index = int.Parse(commandInfo[1]);
                    int damage = int.Parse(commandInfo[2]);
                    if (index >= 0 && index < warship.Count)
                    {
                        warship[index] -= damage;
                        if (warship[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (commandInfo[0]=="Defend")
                {
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);
                    int damage = int.Parse(commandInfo[3]); 
                    if (startIndex >= 0 && startIndex < pirateShip.Count && endIndex>=0 && endIndex<pirateShip.Count && damage>=0)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (commandInfo[0]=="Repair")
                {
                    int indexToRepair = int.Parse(commandInfo[1]);
                    int healt = int.Parse(commandInfo[2]);
                    if (indexToRepair >= 0 && indexToRepair < pirateShip.Count && healt >= 0)
                    {
                        pirateShip[indexToRepair] += healt;
                        if (pirateShip[indexToRepair] > maxHealth)
                        {
                            pirateShip[indexToRepair] = maxHealth;
                        }
                    }
                }
                else if (commandInfo[0]=="Status")
                {
                    int counter = 0;
                    double lowHealth = maxHealth * 0.20;
                    foreach (int i in pirateShip)
                    {
                        if (i<lowHealth)
                        {
                            counter ++;
                        }
                    }
                    Console.WriteLine($"{counter} sections need repair.");

                }

                command= Console.ReadLine();
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warship.Sum()}");
        }
    }
}