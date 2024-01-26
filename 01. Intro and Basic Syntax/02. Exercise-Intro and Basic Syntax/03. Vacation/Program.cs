using System;

namespace _3._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            decimal ticketPerPerson = 0m; ;
            decimal totalPrice = 0m ;
            if (group=="Students")
            {
                if (day=="Friday")
                {
                    ticketPerPerson = 8.45m;
                }
                else if (day=="Saturday")
                {
                    ticketPerPerson = 9.80m;
                }
                else if (day=="Sunday")
                {
                    ticketPerPerson = 10.46m;
                }
            }
            else if (group=="Business")
            {
                if (day == "Friday")
                {
                    ticketPerPerson=10.90m;
                }
                else if (day == "Saturday")
                {
                    ticketPerPerson = 15.60m;
                }
                else if (day == "Sunday")
                {
                    ticketPerPerson = 16m;
                }

            }
            else if (group=="Regular")
            {
                if (day == "Friday")
                {
                    ticketPerPerson=15m;
                }
                else if (day == "Saturday")
                {
                    ticketPerPerson = 20;
                }
                else if (day == "Sunday")
                {
                    ticketPerPerson = 22.50m;
                }
            }
            totalPrice = ticketPerPerson * people;
            if (people>=30&&group=="Students")
            {
                totalPrice = 0.85m * totalPrice;
            }
            if (people>=100&&group=="Business")
            {
                totalPrice = totalPrice - 10 * ticketPerPerson;
            }
            if (10<=people&&people<=20&&group=="Regular")
            {
                totalPrice *= 0.95m;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
