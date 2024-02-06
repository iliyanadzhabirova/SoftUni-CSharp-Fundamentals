using System.Numerics;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<double>>plantRaiting = new Dictionary<string,List<double>>();
            Dictionary<string,double>plantRarity = new Dictionary<string,double>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName= plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);
                if (!plantRarity.ContainsKey(plantName))
                {
                    plantRarity[plantName] = rarity;
                    plantRaiting[plantName] = new List<double>();
                }
                else
                {
                    plantRarity[plantName] = rarity;
                }
            }
            string input = Console.ReadLine();
            while (input != "Exhibition")
            {
                string[] commandInfo = input.Split(new char[] {' ', ':', '-'}, StringSplitOptions.RemoveEmptyEntries);
                string command = commandInfo[0];
                string plant= commandInfo[1];
                if (command== "Rate")
                {
                    if (plantRaiting.ContainsKey(plant))
                    {
                        double raiting = double.Parse(commandInfo[2]);
                        plantRaiting[plant].Add(raiting);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
                }
                else if (command=="Update")
                {
                    if (plantRarity.ContainsKey(plant))
                    {
                        double rarity= double.Parse(commandInfo[2]);
                        plantRarity[plant] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command== "Reset")
                {
                    if (plantRarity.ContainsKey(plant))
                    {
                        plantRaiting[plant].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:") ;
            foreach (var  (plantName,rarity)in plantRarity)
            {
                double average = plantRaiting[plantName].Count>0 ? plantRaiting[plantName].Average() : 0 ;
                Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: { average:f2}");

                //if (plantRaiting[plantName].Count>0)
                //{
                //    double average = plantRaiting[plantName].Average();
                //    Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: { average:f2}");
                //}
                //else
                //{
                //    Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {0:f2}");
                //}
            }
        }
    }
}