namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            double result = MathPower(numberOne, numberTwo);
            Console.WriteLine(result);
        }
        static double MathPower(double numberOne, double numberTwo)
        {
            double result = 1;

            for (int i = 0; i < numberTwo; i++)
            {
                result *= numberOne;
            }
            return result;
        }
    }
}