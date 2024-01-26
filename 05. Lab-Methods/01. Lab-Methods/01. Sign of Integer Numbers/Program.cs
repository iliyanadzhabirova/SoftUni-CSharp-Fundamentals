namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintNumber(n);
        }
        static void PrintNumber(int number)
        {
          
            if (number>0)
            {
                Console.WriteLine($"The number {number} is positive. ");                
            }
            else if (number<0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
        }
    }
}