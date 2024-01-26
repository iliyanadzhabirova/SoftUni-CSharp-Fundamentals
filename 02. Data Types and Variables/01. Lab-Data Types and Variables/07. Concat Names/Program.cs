using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimeter = Console.ReadLine();
            Console.WriteLine($"{firstname}{delimeter}{lastName}");
        }
    }
}
