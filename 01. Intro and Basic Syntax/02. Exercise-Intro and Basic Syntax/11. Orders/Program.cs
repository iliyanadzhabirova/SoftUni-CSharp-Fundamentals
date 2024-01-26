using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;
            for (
                
                int i = 1; i<= orders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                decimal price = ((days * capsulesCount) * pricePerCapsule);
                
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
           
            
            
            
           
        }
    }
}
