using System;

namespace _02._Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number % 10;
            if (numberCopy==0)
            {
                Console.WriteLine("zero");
            }
            else if (numberCopy==1)
            {
                Console.WriteLine("one");
            }
            else if (numberCopy == 2)
            {
                Console.WriteLine("two");
            }
            else if (numberCopy == 3)
            {
                Console.WriteLine("three");
            }
            else if (numberCopy == 4)
            {
                Console.WriteLine("four");
            }
            else if (numberCopy == 5)
            {
                Console.WriteLine("five");
            }
            else if (numberCopy == 6)
            {
                Console.WriteLine("six");
            }
            else if (numberCopy == 7)
            {
                Console.WriteLine("seven");
            }
            else if (numberCopy == 8)
            {
                Console.WriteLine("eight");
            }
            else if (numberCopy == 9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}
