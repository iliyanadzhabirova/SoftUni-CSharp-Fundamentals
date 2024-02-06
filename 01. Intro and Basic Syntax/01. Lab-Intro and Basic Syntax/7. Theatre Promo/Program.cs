using System;

namespace _7._Theatre_Promo
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ticketPrice = 0;

            if (0 <= age && age <= 18)
            {
                if (day == "Weekday")
                {
                    ticketPrice = 12;
                }
                else if (day == "Weekend")
                {
                    ticketPrice = 15;
                }
                else if (day == "Holiday")
                {
                    ticketPrice = 5;
                }
                Console.WriteLine($"{ticketPrice}$");
            }
            else if (18 < age && age <= 64)
            {
                if (day == "Weekday")
                {
                    ticketPrice = 18;
                }
                else if (day == "Weekend")
                {
                    ticketPrice = 20;
                }
                else if (day == "Holiday")
                {
                    ticketPrice = 12;
                }
                Console.WriteLine($"{ticketPrice}$");
            }
            else if (64 < age && age <= 122)
            {
                if (day == "Weekday")
                {
                    ticketPrice = 12;
                }
                else if (day == "Weekend")
                {
                    ticketPrice = 15;
                }
                else if (day == "Holiday")
                {
                    ticketPrice = 10;
                }
                Console.WriteLine($"{ticketPrice}$");
            }

            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
