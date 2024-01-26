using System.Data;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine();
          
            GetResult(command);
        }
        static void GetResult(string command)
        {
            if (command=="int")
            {
                int number=int.Parse(Console.ReadLine());
                number = number * 2;
                Console.WriteLine(number);
            }
            else if (command=="real")
            {
                double number = double.Parse(Console.ReadLine());
                number = number * 1.5;
                Console.WriteLine($"{number:f2}");
            }
            else if(command=="string") 
            {
                string input=Console.ReadLine();
                Console.WriteLine($"${input}$");
            }
        }
    }
}