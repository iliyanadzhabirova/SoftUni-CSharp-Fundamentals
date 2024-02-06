using System;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> targets=Console.ReadLine().Split().Select(int.Parse).ToList();
            string command=Console.ReadLine();

            while (command!="End")
            {
                string[] commandInArr = command.Split();
               
                if (commandInArr[0]=="Shoot")
                {
                    int index = int.Parse(commandInArr[1]);
                    int power = int.Parse(commandInArr[2]);
                    if (index>=0 && index<targets.Count)
                    {
                        int indexValue = targets[index];
                        if (indexValue>power)
                        {
                            targets[index] = indexValue-power;

                        }
                        else
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (commandInArr[0] == "Add")
                {
                    int index = int.Parse(commandInArr[1]);
                    int value = int.Parse(commandInArr[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                       targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }
                else if (commandInArr[0]=="Strike")
                {
                   
                    int indexStart = int.Parse(commandInArr[1]);
                    int radius = int.Parse(commandInArr[2]);
                    if (indexStart >= 0 && indexStart < targets.Count)
                    {
                        if (indexStart - radius < 0 || indexStart + radius >= targets.Count)
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        else
                        {
                            targets.RemoveRange(indexStart, radius+1);
                            indexStart-=radius;
                            targets.RemoveRange(indexStart,radius);
                        }

                    }
                    

                }





                command = Console.ReadLine();
            }
            for (int i = 0; i < targets.Count-1; i++)
            {
                Console.Write(targets[i] + "|");
            }
            Console.Write(targets[targets.Count-1]);
        }

    }
}