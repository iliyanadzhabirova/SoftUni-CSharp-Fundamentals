namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();

            if (input=="int")
            {
                int a = int.Parse(Console.ReadLine());
                int b= int.Parse(Console.ReadLine());

                int GreaterValue = GetMax(a, b);
                Console.WriteLine(GreaterValue);
            }
            else if (input=="char") 
            {
                char a=char.Parse(Console.ReadLine());
                char b= char.Parse(Console.ReadLine());

                char GreaterValue = GetMax(a, b);
                Console.WriteLine(GreaterValue);
            }
            else if (input=="string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                string GreaterValue = GetMax(a, b);
                Console.WriteLine(GreaterValue);
            }
        }
        static int GetMax(int a,int b)
        {
            if (a>b)
            {
                return a;
            }
            return b;
        }
        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static string GetMax(string a, string b)
        {
            int result=a.CompareTo(b);
            if (result>0)
            {
                return a;
            }
            return b;
        }

    }
}