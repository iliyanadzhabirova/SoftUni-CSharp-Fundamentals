using System.Data.Common;

namespace _11._Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber=int.Parse(Console.ReadLine());
            string @operator=Console.ReadLine();
            int secondNumber=int.Parse(Console.ReadLine());

            double result = GetResult(firstNumber,@operator,secondNumber);
            Console.WriteLine(result);
        }
        static double GetResult(double num1,string operation,double num2) 
        {
            double result = 0;
            if (operation=="*")
            {
                result = num1 * num2;
            }
            else if (operation =="+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "/")
            {
                result = num1 / num2;
            }
            return result;
        }
    }
}