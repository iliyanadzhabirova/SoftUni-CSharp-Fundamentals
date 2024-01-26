using System.Collections.Generic;

namespace Problem_2___Treasure
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<string> items=Console.ReadLine().Split("|").ToList();
         string command=Console.ReadLine();
            while (command!= "Yohoho!")
            {
                string[] commandInfo= command.Split(" ");

                if (commandInfo[0]=="Loot")
                {

                    //for (int i = 1; i <= commandInfo.Length; i++)
                    //{
                    //    if (!treasureItems.Contains(commandInfo[i]))
                    //    {
                    //        treasureItems.Insert(0, commandInfo[i]);
                    //    }
                    //}

                    foreach (var item in commandInfo.Skip(1)) 
                    {
                        if (!items.Contains(item))
                        {
                            items.Insert(0,item);
                        }
                    }

                }
                else if (commandInfo[0]=="Drop")
                {
                    int index=int.Parse(commandInfo[1]);
                    if (index>=0 && index <items.Count)
                    {
                        string element = items[index];                      
                        items.RemoveAt(index);
                        items.Add(element);
                    }
                }
                else if (commandInfo[0]=="Steal")
                {
                    List<string>stolenItems=new List<string>();
                    int count =int.Parse( commandInfo[1]);

                    while (count>0&& items.Count>0)
                    { 
                        string currentElement = items[items.Count-1];
                        stolenItems.Add(currentElement);
                        items.RemoveAt(items.Count - 1);
                        count--;
                    }
                    stolenItems.Reverse();
                    Console.WriteLine(string.Join(", ",stolenItems));
                }

                command= Console.ReadLine();
            }
            if (items.Count==0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                //int sum = 0;
                //foreach (string element in treasureItems)
                //{
                //    sum += element.Length;
                //}
                int sum = items.Sum(x => x.Length);
                double averageGain=sum/(double)items.Count;

                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
        }
    }
}