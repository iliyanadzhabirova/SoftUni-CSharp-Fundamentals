namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            GetTopNumber(number);
        }

        private static void GetTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (SumDevisionBy8(i) && OddDigitCheck(i))
                    Console.WriteLine(i);
            }
        }

        private static bool OddDigitCheck(int number)
        {
            while (number > 0)
            {
                if ((number % 10) % 2 == 1)
                    return true;
                number /= 10;
            }

            return false;
        }

        private static bool SumDevisionBy8(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}