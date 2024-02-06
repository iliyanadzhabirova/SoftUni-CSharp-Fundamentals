namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product=Console.ReadLine();
            int quantity=int.Parse(Console.ReadLine());
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    OrderPrice(quantity, price);
                    break;
                case "coke":
                    price = 1.40;
                    OrderPrice(quantity, price);
                    break;
                case "water":
                    price = 1.00;
                    OrderPrice(quantity, price);
                    break;
                   
                case "snacks":
                    price = 2.00;
                    OrderPrice(quantity, price);
                    break;
            }
        }
        static void OrderPrice(int quantity, double price)
        {
            Console.WriteLine($"{quantity * price:f2}");
        }
    }
}