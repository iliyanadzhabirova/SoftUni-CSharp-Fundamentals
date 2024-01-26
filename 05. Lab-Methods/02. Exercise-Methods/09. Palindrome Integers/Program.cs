namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = string.Empty;
            IsItPalindrome(number);
        }

        private static void IsItPalindrome(string number)
        {
            string reversed = string.Empty;
            while (number != "END")
            {
                number = Console.ReadLine();
                if (number == "END")
                {
                    break;
                }

                for (int i = number.Length - 1; i >= 0; i--)
                {
                    reversed += number[i];
                }

                if (reversed != number)
                {
                    Console.WriteLine("false");
                }
                else if (reversed == number)
                {
                    Console.WriteLine("true");
                }

              
                reversed = string.Empty;
               
            }
        }
    }
}