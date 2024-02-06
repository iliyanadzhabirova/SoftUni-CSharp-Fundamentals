namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {

            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());
            

            double factorial1 = GetFactorial(num1);
            double factorial2 = GetFactorial(num2);

            Console.WriteLine($"{factorial1 / factorial2:f2}");
        }

        private static double GetFactorial(long number)
        {
            for (long i = number - 1; i >= 1; i--)
            {
                number = number * i;
            }

            return number;
        }
       
       
    }
}