using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int LostGamesCount = int.Parse(Console.ReadLine());
            double HeadsetPrice = double.Parse(Console.ReadLine());
            double MousePrice = double.Parse(Console.ReadLine());
            double KeyboardPrice = double.Parse(Console.ReadLine());
            double DisplayPrice = double.Parse(Console.ReadLine());

            double HeadsetCost = (LostGamesCount / 2) * HeadsetPrice;
            double MiceCost = (LostGamesCount / 3) * MousePrice;
            double KeyboardCost = (LostGamesCount / 6) * KeyboardPrice;
            double DisplayCost = (LostGamesCount / 12) * DisplayPrice;
            double Expenses = HeadsetCost + MiceCost + KeyboardCost + DisplayCost;

            Console.WriteLine($"Rage expenses: {Expenses:f2} lv.");
        }
    }
}
