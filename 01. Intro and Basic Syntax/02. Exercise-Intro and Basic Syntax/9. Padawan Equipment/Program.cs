using System;

namespace _9._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());

            decimal LightersTotal = students * lightsaberPrice + Math.Ceiling(0.1m * students) * lightsaberPrice;
            decimal RobesTotal = students * robePrice;
            decimal BeltsTotal;
            if (students>=6)
            {
                BeltsTotal = students * beltPrice - students / 6 * beltPrice;
            }
            else
            {
                BeltsTotal = students * beltPrice;
            }
            decimal totalPrice = LightersTotal + BeltsTotal + RobesTotal;
            if (money>=totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {totalPrice-money:F2}lv more.");
            }
        }
    }
}
