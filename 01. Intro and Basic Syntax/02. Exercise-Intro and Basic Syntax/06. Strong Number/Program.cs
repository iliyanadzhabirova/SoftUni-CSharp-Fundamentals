using System;

namespace _6._Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int sum = 0;
            while (numberCopy>0)
            {
                int digit = numberCopy % 10;
                numberCopy = numberCopy / 10;
                int factorial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
            }
            if (sum==number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
