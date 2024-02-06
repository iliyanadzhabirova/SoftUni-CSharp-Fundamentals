using System;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int waitingPeople=int.Parse(Console.ReadLine());
           int[] peopleInLift=Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxPerIndex = 4;
            int peopleSum = 0;
            for (int i = 0; i < peopleInLift.Length; i++)
            {

               int wagon = peopleInLift[i];
                if (wagon < maxPerIndex)
                {
                    if (waitingPeople<4)
                    {
                        wagon = maxPerIndex - waitingPeople;
                    }
                    int addedPeople=maxPerIndex- wagon;
                    peopleInLift[i] = peopleInLift[i]+addedPeople;
                    waitingPeople -= addedPeople;
                }

                peopleSum = peopleInLift.Sum();
                if (waitingPeople == 0 && peopleSum<peopleInLift.Length * 4)
                {
                    Console.WriteLine("The lift has empty spots!"!);
                    foreach (var item in peopleInLift)
                    {
                        Console.Write(item + " ");
                    }
                    return;
                }
                else if (peopleSum==peopleInLift.Length*4&&waitingPeople>0)
                {
                    Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                    foreach (var item in peopleInLift)
                    {
                        Console.Write(item + " ");
                    }
                    return;
                }
                else if (waitingPeople == 0 && peopleSum == peopleInLift.Length * 4)
                {
                    foreach (var item in peopleInLift)
                    {
                        Console.Write(item + " ");
                    }
                    return;
                }
            }
        }
    }
}