using System.Collections.Generic;
using System.Drawing;

namespace Problem_3___Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int []neighborhood=Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            int currentCopidPosition = 0;
            string command = Console.ReadLine();
            while (command!="Love!")
            {
                string[] commandMassive = command.Split();
                int jump = int.Parse(commandMassive[1]);
                if (currentCopidPosition+jump>=neighborhood.Length)
                {
                    currentCopidPosition = 0;
                }
                else
                {                
                    currentCopidPosition += jump;
                }
                neighborhood[currentCopidPosition] -= 2;

                if (neighborhood[currentCopidPosition]==0)
                {
                    Console.WriteLine($"Place {currentCopidPosition} has Valentine's day.");
                }
                if (neighborhood[currentCopidPosition]<0)
                {
                    Console.WriteLine($"Place {currentCopidPosition} already had Valentine's day.");
                }
                command = Console.ReadLine();   
            }
            Console.WriteLine($"Cupid's last position was {currentCopidPosition}.");
            if (!neighborhood.Any(number=>number>0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighborhood.Count(number=>number>0)} places.");
            }
        }
    }
}