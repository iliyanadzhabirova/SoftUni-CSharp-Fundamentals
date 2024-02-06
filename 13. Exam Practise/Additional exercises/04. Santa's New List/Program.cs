using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Santa_s_New_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var children = new Dictionary<string, Dictionary<string, int>>();
            var presents = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] parts = input.Split("->");
                string childName = parts[0];
                if (parts[0] == "Remove")
                {
                    childName = parts[1];
                    children.Remove(childName);
                }
                else
                {
                    string typeOfPresent = parts[1];
                    int amount = int.Parse(parts[2]);

                    if (!children.ContainsKey(childName))
                    {
                        children[childName] = new Dictionary<string, int>();
                    }

                    if (!children[childName].ContainsKey(typeOfPresent))
                    {
                        children[childName][typeOfPresent] = 0;
                    }

                    children[childName][typeOfPresent] += amount;

                    if (!presents.ContainsKey(typeOfPresent))
                    {
                        presents[typeOfPresent] = 0;
                    }

                    presents[typeOfPresent] += amount;
                }
            }

            Console.WriteLine("Children:");
            foreach (var child in children.OrderByDescending(c => c.Value.Values.Sum()).ThenBy(c => c.Key))
            {
                Console.WriteLine($"{child.Key} -> {child.Value.Values.Sum()}");
            }

            Console.WriteLine("Presents:");
            foreach (var present in presents.OrderBy(p => p.Key))
            {
                Console.WriteLine($"{present.Key} -> {present.Value}");
            }
        }
    }
}

    
    

