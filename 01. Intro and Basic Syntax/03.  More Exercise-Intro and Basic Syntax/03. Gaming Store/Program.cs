using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = decimal.Parse(Console.ReadLine());
            decimal balanceCopy = balance;
           
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Game Time")
                {
                    break;
                }
                if (input=="OutFall 4")
                {
                    if (balance >= 39.99m)
                    {
                        balance -= 39.99m;
                        Console.WriteLine("Bought OutFall 4");
                    }
                    else 
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    if (balance==0)
                    {
                        Console.WriteLine("Out of money!");
                    }
                }
                else if (input == "CS: OG")
                {
                    
                    if (balance >= 15.99m)
                    {
                        balance -= 15.99m;
                        Console.WriteLine("Bought CS: OG");
                    }
                    else 
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                    }
                }
                
                    else if (input == "Zplinter Zell")
                { 
                    if (balance >= 19.99m)
                    {
                        balance -= 19.99m;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                    else 
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                    }
                }
                else if (input == "Honored 2")
                {
                    if (balance >= 59.99m)
                    {
                        balance -= 59.99m;
                        Console.WriteLine("Bought Honored 2");
                    }
                    else 
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                    }
                }
                else if (input == "RoverWatch")
                {
                    if (balance >= 29.99m)
                    {
                        balance -= 29.99m;
                        Console.WriteLine("Bought RoverWatch");
                    }
                    else 
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                    }
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    if (balance >= 39.99m)
                    {
                        balance -= 39.99m;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                

            }
            if (balance > 0)
            {
                Console.WriteLine($"Total spent: ${balanceCopy - balance}. Remaining: ${balance}");
            }
        }
    }
}
