using System.Reflection.PortableExecutable;
using System;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split((" "),StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            int counter = 0;
            int moves = 0;

            while (command != "end")
            {
                int[] indexes=command.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int firstIndex = indexes[0];
                int secondIndex = indexes[1];
                moves++;
                if (firstIndex==secondIndex||firstIndex<0||secondIndex<0||firstIndex>=cards.Count||secondIndex>=cards.Count)
                {
                    int middleIndex = cards.Count / 2;
                    cards.Insert(middleIndex, $"-{moves}a");
                    cards.Insert(middleIndex, $"-{moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (cards[firstIndex] == cards[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {cards[firstIndex]}!");
                    if (firstIndex>secondIndex)
                    {
                        cards.RemoveAt(firstIndex);
                        cards.RemoveAt(secondIndex);
                    }
                    else
                    {
                        cards.RemoveAt(secondIndex);
                        cards.RemoveAt(firstIndex);
                    }
                    
                }
                else if (cards[firstIndex] != cards[secondIndex])
                {
                    Console.WriteLine("Try again!");
                }
                
                if (cards.Count==0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }



                command= Console.ReadLine();
            }
            if (cards.Count>0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", cards));
            }
          
        }
    }
}