using System.Diagnostics;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            double totalNoTaxes = 0;
            while (input!="special"&&input!="regular")
            {
                double itemPrice=double.Parse(input);

                if (itemPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                
                else if(itemPrice>0)
                {
                    totalNoTaxes += itemPrice;
                }

                input=Console.ReadLine();
            }
            double totalWithTaxes = totalNoTaxes + totalNoTaxes * 0.2;
             if (totalWithTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            if (input=="special")
            {
                totalWithTaxes = 0.9 * totalWithTaxes;
            }
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalNoTaxes:f2}$");
            Console.WriteLine($"Taxes: {totalNoTaxes*0.2:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalWithTaxes:f2}$");
        }
    }
}