namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            string result=NewString(input,repeat);

            Console.WriteLine(result);
        }
        static string NewString(string input, int repeat)
            {
            string result = "";
            for (int i = 0; i < repeat; i++)
            {
                result+= input;
            }
            return result;
        }
    }
}